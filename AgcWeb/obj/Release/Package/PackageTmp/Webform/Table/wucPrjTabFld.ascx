<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPrjTabFld.ascx.cs"
    Inherits="AGC.Webform.wucPrjTabFld" %>



<script>
    var strchkIsTabPrimary = "";
    var strddlFieldTypeId = "";

    function OnCheckChange() {
        //     if (chkIsTabPrimary.Checked == true)
        //{
        //	ddlFieldTypeId.SelectedValue = "02";
        //	ddlFieldTypeId.Enabled = false;
        //}
        //else
        //{
        //	ddlFieldTypeId.SelectedValue = "01";
        //	ddlFieldTypeId.Enabled = true;
        //}
        var chkIsTabPrimary = document.getElementById(strchkIsTabPrimary);
        var ddlFieldTypeId = document.getElementById(strddlFieldTypeId);

        //var lblTest = document.getElementById("lblTest");
        if (chkIsTabPrimary.checked == true) {
            ddlFieldTypeId.disabled = true;
            ddlFieldTypeId.options[2].selected = true
        }
        else {
            ddlFieldTypeId.disabled = false;
            ddlFieldTypeId.options[1].selected = true
        }
    }
</script>
<table id="tabwucPrjTabFld" cellspacing="3" cellpadding="3"
    border="0" class="auto-style8">
    <tr>
        <td style="width: 85px; height: 33px; vertical-align: top" colspan="1" rowspan="1" class="NameTD">
            <asp:Label ID="lblFldID" runat="server" CssClass="text-secondary">字段名称</asp:Label>
        </td>
        <td style="height: 33px; vertical-align: top" colspan="2" rowspan="1">
            <asp:TextBox ID="txtFldName" runat="server" Width="367px" ReadOnly="True" class="form-control-sm"></asp:TextBox>
            <div class="MemoStyle1" style="display: inline; width: 225px; height: 30px">
                <span style="font-size: 14px;">这里显示表的字段名称，不能编辑。</span>
            </div>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 85px; height: 30px; vertical-align: top" align="right">
            <asp:Label ID="Label1" runat="server" CssClass="text-secondary">字段类型</asp:Label></td>
        <td style="vertical-align: top" class="auto-style2">

            <asp:DropDownList ID="ddlFieldTypeId" runat="server" Width="160px" class="form-control-sm">
            </asp:DropDownList>

        </td>
        <td style="height: 30px; vertical-align: top">

            <div class="MemoStyle1" style="display: inline; width: 480px; height: 32px">
                <span style="font-size: 14px;">字段类型，主要是生成代码时一些决定依据。</span>
            </div>

        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 85px; height: 30px; vertical-align: top">
            <asp:Label ID="lblPrimaryTypeId" CssClass="text-secondary" runat="server">主键类型</asp:Label>
        </td>
        <td style="vertical-align: top" class="auto-style3">
            <asp:DropDownList ID="ddlPrimaryTypeId" runat="server" Width="160px" class="form-control-sm">
            </asp:DropDownList></td>
        <td style="height: 30px; vertical-align: top">

            <div class="MemoStyle1" style="display: inline; width: 480px; height: 32px">
                <span style="font-size: 14px;">主键的类型，是指一般主键，还是标识主键(Identity)</span>
            </div>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 85px; height: 30px; text-align: right; vertical-align: top">
            <asp:Label ID="lblPrimaryTypeId0" runat="server" CssClass="text-secondary">操作类型</asp:Label>
        </td>
        <td style="vertical-align: top" class="auto-style3">
            <asp:DropDownList ID="ddlFldOpTypeId" runat="server" Width="160px" class="form-control-sm">
            </asp:DropDownList></td>
        <td style="height: 30px; vertical-align: top">
            <div class="MemoStyle1" style="display: inline; width: 480px; height: 32px">
                <span style="font-size: 14px;">操作类型：可读写、只读、只写、不可读可。</span>
            </div>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 85px; height: 30px; vertical-align: top; text-align: right">
            <asp:Label ID="Label7" runat="server" CssClass="text-secondary">是否唯一</asp:Label></td>
        <td colspan="1" style="vertical-align: top" class="auto-style4">
            <asp:CheckBox ID="chkIsTabUnique" runat="server" AutoPostBack="True" class="form-control-sm"
                OnCheckedChanged="chkIsTabPrimary_CheckedChanged" Text="是否表中唯一" /></td>
        <td style="height: 30px; vertical-align: top">
            <div class="MemoStyle1" style="display: inline; width: 480px; height: 17px">
                <span style="font-size: 14px;">该属性用来决定在数据表是否唯一。</span>
            </div>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 85px; height: 30px; vertical-align: top" align="right">
            <asp:Label ID="Label6" runat="server" CssClass="text-secondary">表外键</asp:Label></td>
        <td style="vertical-align: top" colspan="1" class="auto-style4">

            <asp:CheckBox ID="chkIsTabForeignKey" runat="server" Text="是否表外键" class="form-control-sm"></asp:CheckBox>

        </td>
        <td style="height: 30px; vertical-align: top">

            <div class="MemoStyle1" style="display: inline; width: 478px; height: 24px">
                <span style="font-size: 14px;">表外键：一般是代码字段，在其他表中该字段是一个主键，代码一个对象标识。</span>
            </div>

        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 85px; height: 30px; vertical-align: top">

            <asp:Label ID="lblForeignKeyTabId" runat="server" CssClass="text-secondary">外键表</asp:Label>

        </td>
        <td style="vertical-align: top" class="auto-style5">
            <asp:DropDownList ID="ddlForeignKeyTabId" runat="server" Width="160px" class="form-control-sm">
            </asp:DropDownList></td>
        <td style="height: 30px; vertical-align: top">
            <div class="MemoStyle1" style="display: inline; width: 344px; height: 30px">
                <span style="font-size: 14px;">表外键所在的工程表。</span>
            </div>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 85px; height: 46px; vertical-align: top" align="right">
            <asp:Label ID="Label3" runat="server" CssClass="text-secondary">父对象</asp:Label></td>
        <td style="vertical-align: top" colspan="1" class="auto-style6">

            <asp:CheckBox ID="chkIsParentObj" runat="server" Text="是否父对象" class="form-control-sm"></asp:CheckBox>

        </td>
        <td style="height: 36px; vertical-align: top">

            <div style="display: inline; width: 479px; height: 35px" class="MemoStyle1">
                <span style="font-size: 14px;">父对象说明该字段是当前表的父对象，往往是代码字段，如果是父对象，将会在生成代码为你生成该字段的一个Session型属性，用于方便地存取该字段属性。</span>
            </div>

        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 85px; vertical-align: top" align="right">
            <asp:Label ID="Label4" runat="server" CssClass="text-secondary">是否可空</asp:Label></td>
        <td style="vertical-align: top" colspan="1" class="auto-style7">

            <asp:CheckBox ID="chkIsTabNullable" runat="server" Text="表中是否可空" class="form-control-sm"></asp:CheckBox></td>
        <td style="vertical-align: top;">

            <div class="MemoStyle1" style="display: inline; width: 480px; height: 30px">
                <span style="font-size: 14px;">该属性用来决定在数据表中是否可空。</span>
            </div>

        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 85px; vertical-align: top">
            <asp:Label ID="lblMemo" runat="server" CssClass="text-secondary">说明</asp:Label>
        </td>
        <td style="vertical-align: top;" colspan="2">
            <p>
                <asp:TextBox ID="txtMemoInTab" runat="server" Width="655px"
                    TextMode="MultiLine" Height="48px"
                    class="form-control-sm"></asp:TextBox>
            </p>
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server">字段ID</asp:Label></td>
        <td>
            <asp:TextBox ID="txtFldID" runat="server" Width="136px" ReadOnly="True"></asp:TextBox></td>
        <td></td>
    </tr>

</table>
<asp:Literal ID="litScript" runat="server"></asp:Literal>