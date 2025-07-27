<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFunction4GeneCodeB.ascx.cs" Inherits="AGC.Webform.wucFunction4GeneCodeB" %>

<style type="text/css">
    .FirstCol
    {
        width:80px;
    }
    table
    {
        width:90%;
    }
</style>
<script src="../../js/tzPubFun.js"></script>
<script>
    function ShowHideProperty()
    {
        var tabGeneralProp = document.getElementById("tabGeneralProp");
        var btnHideProperty = document.getElementById("btnHideProperty");
        console.log(btnHideProperty);
        if (tabGeneralProp == null) return;
        if (btnHideProperty.value === "隐藏属性")
        {
            console.log(tabGeneralProp);
            btnHideProperty.value = "显示属性"
            tabGeneralProp.style.display = 'none';
        }
        else
        {
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
<table id="tabwucFunction4GeneCode" style="padding: 1px;" border="0" >
    <tr>
        <td class="NameTD FirstCol">
            <asp:Label ID="lblFuncId4GC" runat="server" CssClass="col-form-label text-right">函数ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncId4GC" runat="server" class="form-control-sm" Width="357px"></asp:TextBox>
            <asp:CheckBox ID="chkIsTemplate" runat="server" Text="是否模板" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td colspan="1">
            <input id="btnHideProperty" type="button" value="隐藏属性" onclick="ShowHideProperty();" class="btn btn-outline-info btn-sm" />
            

        </td>
        <td>
            <input id="btnHideProperty0" type="button" value="生成代码" onclick="ShowGeneCode();" class="btn btn-outline-info btn-sm" />

           </td>
        <td> 
                    <asp:DropDownList ID="ddlTabId" style="display:none" runat="server">
                    </asp:DropDownList>
                </td>
        <td>
            <asp:Button ID="btnOKGeneCode" style="display:none" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnGeneCode_Click" Text="确定生成" />
        </td>
    </tr>
</table>
<table id="tabGeneralProp">
    <tr>
        <td class="NameTD FirstCol">
            <asp:Label ID="lblFuncName" runat="server" CssClass="col-form-label text-right">函数名</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtFuncName" runat="server" class="form-control-sm" Height="32px" TextMode="MultiLine" Width="800px"></asp:TextBox>
        </td>

        <td class="ValueTD">
            &nbsp;</td>

        <td class="ValueTD">
            &nbsp;</td>

    </tr>
     <tr>
        <td class="NameTD">
            <asp:Label ID="Label5" runat="server" CssClass="col-form-label text-right">Code函数名</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:DropDownList ID="ddlFuncId4Code" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
         

    </tr>
   
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label text-right">序号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" runat="server" class="form-control-sm" Width="251px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">功能</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:DropDownList ID="ddlFeatureId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>

        <td class="ValueTD">
            &nbsp;</td>

        <td class="ValueTD">
            &nbsp;</td>

    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProgLangTypeId" runat="server" CssClass="col-form-label text-right">语言类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlProgLangTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblCodeTypeId" runat="server" CssClass="col-form-label text-right">分层类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCodeTypeId" runat="server" class="form-control-sm">
            </asp:DropDownList>
        </td>
     
        <td>
            &nbsp;</td>
     
        <td>
            &nbsp;</td>
     
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">数据源类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlSqlDsTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblPrjId" runat="server" CssClass="col-form-label text-right">工程</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblReturnTypeID" runat="server" CssClass="col-form-label text-right" >返回类型</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlReturnTypeID" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblFuncTypeID" runat="server" CssClass="col-form-label text-right">函数类型</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlFuncTypeID" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
     <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Width="800px" Height="47px" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>

    </tr>
</table>
<table>
    <tr>
        <td class="NameTD FirstCol">
            <asp:Label ID="lblFuncCode" runat="server" CssClass="col-form-label text-right">函数代码</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtFuncCode" runat="server" class="form-control-sm" Width="800px" Height="281px" TextMode="MultiLine"></asp:TextBox>
        </td>

    </tr>

   
</table>
<table>
    <tr>
        <td class="NameTD FirstCol">
            <asp:Label ID="Label4" runat="server" CssClass="col-form-label text-right">生成代码</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtGeneCode" runat="server" class="form-control-sm" Width="800px" Height="281px" TextMode="MultiLine"></asp:TextBox>
        </td>

    </tr>

   
</table>
