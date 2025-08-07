<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucGenViewCode.ascx.cs"
    Inherits="AGC.Webform.wucGenViewCode" %>


<script src="../../js/tzPubFun.js"></script>

<style>
    .ulhorizontal li {
        float: left;
    }
</style>
<script>
    function GenControlCode() {

        var txtCode = getObjByTagAndId("textarea", "txtCode");
        if (txtCode != null) {
            txtCode.value = "";
        }
        var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
        if (txtCode_Sim != null) {
            txtCode_Sim.value = "";
        }
        var divCode = getObjByTagAndId("div", "divCode");
        CallServer("GenControlCode|1!", divCode);

    }
    function GenCtlControlCode() {

        var txtCode = getObjByTagAndId("textarea", "txtCode");
        if (txtCode != null) {
            txtCode.value = "";
        }
        var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
        if (txtCode_Sim != null) {
            txtCode_Sim.value = "";
        }
        var divCode = getObjByTagAndId("div", "divCode");
        CallServer("GenCtlControlCode|1!", divCode);

    }
    function ClearText(txtCode) {
        var txtCode = getObjByTagAndId("textarea", "txtCode");
        if (txtCode != null) {
            txtCode.value = "";
        }
        var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
        if (txtCode_Sim != null) {
            txtCode_Sim.value = "";
        }
    }
</script>
<div id="Table1" style="width: 100%">
    <div style="width: 100%; float: left;">
        <div style="width: 30%; float: left">
            <ul class="ulhorizontal">
                <li>
                    <asp:Label ID="lblPageTitle" runat="server" CssClass="RegionTitleH2" Width="393px">生成Android App界面</asp:Label>

                </li>
                <li></li>
            </ul>
        </div>
        <div style="width: 65%; float: right">
            <asp:Label ID="lblMsg2"
                runat="server" Height="13px" ForeColor="Red"></asp:Label>
        </div>
    </div>
    <div style="width: 100%; float: left; min-height: 60px;">

        <asp:Panel ID="pnlCodeTypeLst" Style="width: 100%; left: 0px; text-align: left; min-height: 60px;" runat="server">
            <asp:Button ID="Button1" runat="server" Text="Button1" />
            <asp:Button ID="Button2" runat="server" Text="Button2" />
        </asp:Panel>


    </div>
    <div style="width: 100%">
        <div>
            <table style="width: 100%;" class="msgtable">
                <tr>
                    <th style="text-align: left">
                        <asp:Label ID="lblEditDepartmentInfo" runat="server"
                            CssClass="h6">代码区域</asp:Label>
                        <asp:Label ID="lblMsgEdit" runat="server"
                            Width="380px" CssClass="auto-style10"></asp:Label>
                    </th>

                </tr>
            </table>
        </div>

        <div id="divCode" style="width: 100%;" runat="server">

            <div style="width: 760px; height: 32px">
                <table>
                    <tr>

                        <td>
                            <asp:Label ID="Label1" Style="z-index: 103; left: 152px; top: 8px"
                                runat="server" CssClass="text-secondary">生成类名：</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 248px; top: 8px" Width="600px"
                                runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 600px; top: 8px"
                                runat="server" OnClick="lbDownLoadFile_Click">下载文件</asp:LinkButton>

                        </td>
                    </tr>
                </table>
            </div>

            <div>
                <asp:Label ID="Label5"
                    runat="server" Width="113px" CssClass="auto-style11">代码文件路径：</asp:Label>
                <asp:TextBox ID="txtFolderName4GenCode" runat="server" Width="585px" CssClass="auto-style9"></asp:TextBox>
            </div>

            <div>

                <asp:Literal ID="litCode" runat="server"></asp:Literal>
            </div>
            <div>
            </div>
        </div>
    </div>
</div>

