<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucFeatureButtonLst.ascx.cs"
    Inherits="AGC.Webform.wucFeatureButtonLst" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<script src="../../js/tzPubFun.js"></script>
<script>
    var arrSelCtrlId = new Array();
    Array.prototype.indexOf = function(val) { 
for (var i = 0; i < this.length; i++) { 
if (this[i] == val) return i; 
} 
return -1; 
};
    Array.prototype.remove = function (val) {
        var index = this.indexOf(val);
        if (index > -1) {
            this.splice(index, 1);
        }
    };
    Array.prototype.contains1 = function (id) {
        var i = this.length;
        while (i--) {
            if (id.indexOf(this[i]) > -1) {
                return true;
            }
        }
        return false;
    }
    Array.prototype.contains = function (id) {
        var i = this.length;
        while (i--) {
            if (id === this[i]) {
                return true;
            }
        }
        return false;
    }
    function ReSelectFeature() {
        var hidSelCtrlId = getObjByTagAndId('input', 'hidSelCtrlId');
        if (hidSelCtrlId.value == "") return;

        var arrCtrlId = hidSelCtrlId.value.split(','); 
        if (arrCtrlId == null) {
            return;
        }
        var arrDiv0 = document.getElementsByTagName("div");
        var arrDiv = GetArray(arrDiv0);
        arrDiv = arrDiv.filter(x => x.id.indexOf('pnlFeatureLst') > -1);
        if (arrDiv.length == 0) {
            alert('在当前界面中没有找到Div:pnlControlLst. (In ReSelectFeature of wucFeatureButtonLst.ascx) ');
            return;
        }
        var divContainer = arrDiv[0];
        var arrInput0 = divContainer.getElementsByTagName('input');
        var arrInput = GetArray(arrInput0);
        console.log(arrInput);
        if (arrInput == null) return;
        arrInput = arrInput.filter(x => arrCtrlId.contains1(x.id));
        arrInput.forEach(x => x.className = "btn btn-info btn-sm");
              
    }
       

    function btnSel_Click(strCtrlId) {
        var thisChk = event.target;

        console.log(thisChk);
        //alert(thisChk.id);
        var td_parent;
        //if (thisChk.localName == "input") {
        //    td_parent = thisChk.parentNode;
        //    console.log(td_parent);
        //}
        //alert(thisChk.id);
        var hidSelCtrlId = getObjByTagAndId("input", "hidSelCtrlId");
        if (hidSelCtrlId == null) {
            alert("存放已选的功能Id列表的控件(hidSelCtrlId)不存在，请检查！");
        }
        if (arrSelCtrlId.indexOf(strCtrlId) > -1) {
            arrSelCtrlId.remove(strCtrlId);
            thisChk.className = "btn btn-outline-info btn-sm border-secondary";
        }
        else {
            arrSelCtrlId.push(strCtrlId);
            thisChk.className = "btn btn-info btn-sm";
        }
        hidSelCtrlId.value = arrSelCtrlId.join(',');
    }

</script>
<div class="border border-danger" style="width:100%">
    <ul class="nav">
        <li class="nav-item">
            <asp:Label ID="lblTitle" runat="server" Text="可视化控件列表" CssClass="text-warning"></asp:Label>
            <asp:Label ID="lblTitleOutUse" runat="server" Width="150px" Text="功能区域不使用" CssClass="text-warning"></asp:Label>

        </li>
        <li class="nav-item mt-2">
            <asp:Panel ID="pnlFeatureLst" runat="server">
            </asp:Panel>
        </li>
    </ul>
</div>



