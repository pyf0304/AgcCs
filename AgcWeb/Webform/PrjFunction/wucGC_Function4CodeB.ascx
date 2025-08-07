<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucGC_Function4CodeB.ascx.cs" Inherits="AGC.Webform.wucGC_Function4CodeB" %>

<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<script>
    function ShowCode(hidCodeName) {
        var txtCode = document.getElementById("txtCode");
        console.log(txtCode);
        var hidCode = document.getElementById(hidCodeName);
        console.log(hidCode);


        txtCode.value = hidCode.value;
        hidCode.value = "";
        //var txtClassName4GC = document.getElementById("txtClassName4GC");
        //if (txtClassName4GC != null) {
        //    txtClassName4GC.value = objJSON.ClassName;
        //}
        //if (txtFileName4GC != null) {
        //    txtFileName4GC.value = objJSON.FileName;
        //}
        //$('#txtCode').val(strCode);
    }
</script>
<div>
    <div style="width: 100%; ">
        <div>
            <ul class="nav">
                <li class="nav-item">
                    <asp:Button ID="btnGeneCode0" runat="server" Text="生成代码" CssClass="btn btn-outline-info btn-sm" OnClick="btnGeneCode_Click" />
                </li>
                <li class="nav-item">
                    <asp:Label ID="lblGC0" runat="server" Text="Label"></asp:Label>
                </li>
            </ul>
        </div>
        <div class="mt-3">
            <ul class="nav">
                <li class="nav-item">
                    <asp:Button ID="btnGeneCode1" runat="server" Text="生成代码" CssClass="btn btn-outline-info btn-sm" OnClick="btnGeneCode_Click" />
                </li>
                <li class="nav-item">
                    <asp:Label ID="lblGC1" runat="server" Text="Label"></asp:Label>
                </li>
            </ul>
        </div>
        <div class="mt-3">
            <ul class="nav">
                <li class="nav-item">
                    <asp:Button ID="btnGeneCode2" runat="server" Text="生成代码" CssClass="btn btn-outline-info btn-sm" OnClick="btnGeneCode_Click" />
                </li>
                <li class="nav-item">
                    <asp:Label ID="lblGC2" runat="server" Text="Label"></asp:Label>
                </li>
            </ul>
        </div>
        <div class="mt-3">
            <ul class="nav">
                <li class="nav-item">
                    <asp:Button ID="btnGeneCode3" runat="server" Text="生成代码" CssClass="btn btn-outline-info btn-sm" OnClick="btnGeneCode_Click" />
                </li>
                <li class="nav-item">
                    <asp:Label ID="lblGC3" runat="server" Text="Label"></asp:Label>
                </li>
            </ul>
        </div>
    </div>
    <div style="width: 100%; " class="mt-3">
        <%--<asp:TextBox ID="txtCode" runat="server" TextMode="MultiLine" Height="275px" Width="1021px"></asp:TextBox>--%>
        <textarea id="txtCode" rows="30" style="width:95%"></textarea>
        <asp:HiddenField ID="hidCode" EnableViewState="false" ViewStateMode="Disabled" runat="server" />
    </div>

</div>
