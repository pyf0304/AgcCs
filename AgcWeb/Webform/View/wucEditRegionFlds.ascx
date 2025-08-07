<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucEditRegionFlds.ascx.cs"
    Inherits="AGC.Webform.wucEditRegionFlds" %>
<%@ Register Src="~/Webform/CommonControl/wucEditControl.ascx" TagPrefix="uc1" TagName="wucEditControl" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<script>
    var txtChangeEventName = "";
    var txtClickEventName = "";
    function SetDefaEventName() {
        var txtChangeEvent = document.getElementById(txtChangeEventName);
        console.log("txtChangeEvent", txtChangeEvent);
        //绑定事件
        if (txtChangeEvent != null) {
            txtChangeEvent.onfocus = function () {
                //alert('txtChangeEvent.onfocus');
                var strDefaChangeEventName = txtChangeEvent.getAttribute("DefaChangeEvent");
                console.log("strDefaChangeEventName", strDefaChangeEventName);

                if (strDefaChangeEventName != "" && txtChangeEvent.value == "") {
                    txtChangeEvent.value = strDefaChangeEventName;
                }
            }
        }
        var txtClickEvent = document.getElementById(txtClickEventName);
        console.log("txtClickEvent", txtClickEvent);
        //绑定事件
        if (txtClickEvent != null) {

            txtClickEvent.onfocus = function () {
                //alert('txtClickEvent.onfocus');
                var strDefaClickEvent = txtClickEvent.getAttribute("DefaClickEvent");
                console.log("strDefaClickEvent", strDefaClickEvent);
                if (strDefaClickEvent != "" && txtClickEvent.value == "") {
                    txtClickEvent.value = strDefaClickEvent;
                }
            }
        }
    }


    //window.onload = function () {
    //    //需求：京东的获取焦点
    //    //思路：京东的input按钮获取了插入条光标立刻删除内容。失去插入条光标显示文字
    //    //获取事件源和相关元素
    //    var inp1 = document.getElementById("inp1");
    //    console.log("inp1", inp1);
    //    //绑定事件
    //    inp1.onfocus = function () {

    //        //书写驱动程序
    //        if (this.value == "我是京东") {
    //            this.value = "";
    //        }
    //    }
    //    inp1.onblur = function () {
    //        if (this.value === "") {
    //            this.value = "我是京东";
    //        }
    //    }

    //}

</script>
<table id="tabwucEditRegionFlds" style="width: 400px;">
    <tr>
        <td class="text-right">
            <asp:Label ID="lblTabFldId" Width="100px" runat="server" CssClass="col-form-label-sm">表字段</asp:Label>

        </td>
        <td>
            <asp:DropDownList ID="ddlFldId" runat="server"
                Width="300px">
            </asp:DropDownList>
        </td>

    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label-sm">标签标题</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtLabelCaption" runat="server" CssClass="form-control-sm" Width="300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label-sm">跨列</asp:Label>
        </td>
        <td>
            <table>
                <tr>
                    <td>
                        <asp:TextBox ID="txtColSpan" runat="server" CssClass="form-control-sm" Width="60px"></asp:TextBox>

                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" CssClass="col-form-label-sm">列宽</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtWidth" runat="server" CssClass="form-control-sm" Width="110px"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label5" runat="server" CssClass="col-form-label-sm">序号</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtSeqNum" runat="server" CssClass="form-control-sm" Width="60px"></asp:TextBox></td>
                    <td>
                        <asp:CompareValidator ID="ComValid_SeqNum" runat="server"
                            ErrorMessage="请输入整型数值!" ControlToValidate="txtSeqNum" Type="Integer" Operator="DataTypeCheck"
                            EnableClientScript="false"></asp:CompareValidator></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>

        <td class="text-right">
            <asp:Label ID="Label1" Width="100px" runat="server" CssClass="col-form-label-sm">In/Out类型</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlInOutTypeId" runat="server" CssClass="form-control-sm"
                Width="300px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td colspan="2">
            <uc1:wucEditControl runat="server" ID="wucEditControl1" />
        </td>
    </tr>


    <tr id="trClickEvent">
        <td class="text-right">
            <asp:Label ID="lblClickEvent" name="lblClickEvent" CssClass="col-form-label text-right" Width="90px" Text="Click事件" runat="server" />
        </td>
        <td class="text-left" colspan="3">
            <asp:TextBox ID="txtClickEvent" name="txtClickEvent" CssClass="form-control" AutoCompleteType="None" Width="300px" runat="server" />
        </td>
    </tr>
    <tr id="trChangeEvent">
        <td class="text-right">
            <asp:Label ID="lblChangeEvent" name="lblChangeEvent" CssClass="col-form-label text-right" Width="90px" Text="Change事件" runat="server" />
        </td>
        <td class="text-left" colspan="3">
            <asp:TextBox ID="txtChangeEvent" name="txtChangeEvent" CssClass="form-control" AutoCompleteType="None" Width="300px" runat="server" />

        </td>
    </tr>
    <tr>
        <td class="text-right">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label-sm">说明</asp:Label></td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" CssClass="form-control-sm"
                Width="300px" Height="66px" TextMode="MultiLine"></asp:TextBox></td>
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
            <asp:Label ID="lblUpdDate" runat="server">修改日期</asp:Label></td>
        <td>
            <asp:TextBox ID="txtUpdDate" runat="server"></asp:TextBox></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
    </tr>
</table>
