<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucFeatureRegionButton4Visible.ascx.cs"
    Inherits="AGC.Webform.wucFeatureRegionButton4Visible" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<script src="../../js/tzPubFun.js"></script>
<script src="../../js/tzGridView.js"></script>
<script src="../../js/tzCtrl.js"></script>
<script>
     Array.prototype.contains1 = function (id) {
        var i = this.length;
         while (i--) {
             let iPos = id.indexOf(this[i]);
             if (iPos > -1) {
                 let strEndStr = id.substring(iPos);
                 if (strEndStr === this[i]) return true;
                 else return false;
            }
        }
        return false;
    }
    function ReSelectCtrl() {
        var arrCtrlId = GetCheckedItems4Gv('gvFeatureRegionFlds');
        if (arrCtrlId == null) {
            return;
        }
        var arrDiv0 = document.getElementsByTagName("div");
        var arrDiv = GetArray(arrDiv0);
        arrDiv = arrDiv.filter(x => x.id.indexOf('pnlControlLst') > -1);
        if (arrDiv.length == 0) {
            alert('在当前界面中没有找到Div:pnlControlLst. (In ReSelectCtrl of wucFeatureRegionButton4Visible.ascx) ');
            return;
        }
        var divContainer = arrDiv[0];
        var arrInput0 = divContainer.getElementsByTagName('input');
        var arrInput = GetArray(arrInput0);
        console.log(arrInput);
        if (arrInput == null) return;
        arrInput = arrInput.filter(x => arrCtrlId.contains1(x.id));
        arrInput.forEach(x => SelectOneCtrl(x));

        var arrSelect0 = divContainer.getElementsByTagName('select');
        var arrSelect = GetArray(arrSelect0);
        console.log(arrSelect);
        if (arrSelect == null) return;
        arrSelect = arrSelect.filter(x => arrCtrlId.contains1(x.id));
        arrSelect.forEach(x => SelectOneCtrl(x));
    }

    function Update(strCtrlId) {
        var btnUpdate4Gv = getObjByTagAndId('input', 'btnUpdate4Gv');
        if (btnUpdate4Gv == null) {
            alert("btnUpdate4Gv按钮不存在！");
        }
        var arrInput0 = document.getElementsByTagName("input");
        var arrInput = GetArray(arrInput0);
        arrInput = arrInput.filter(x => x.type == "hidden");
        arrInput = arrInput.filter(x => x.id.indexOf('hidCtrlId') > -1);
        if (arrInput.length > 0) {
            var hidCtrlId = arrInput[0];
            console.log('hidCtrlId:');
            console.log(hidCtrlId);
            hidCtrlId.value = strCtrlId;
        }
        if (btnUpdate4Gv != null) {
            btnUpdate4Gv.click();
        }
    }
    function txt_Click(strCtrlId, event) {
          event = window.event || event;
        var bolIsPressShift = false;
        if (event.shiftKey == 1) {
            bolIsPressShift = true;
            console.log("shift被按下了, strCtrlId:" + strCtrlId)
        }
        else {
            bolIsPressShift = false;
            console.log("shift没被按下,strCtrlId:" + strCtrlId)
        }
        var thisChk = event.target;

        console.log(thisChk);
        //alert(thisChk.id);
         var td_parent;
        if (thisChk.localName == "span") {
            td_parent = thisChk.parentNode;
            console.log(td_parent);
        }
        //alert(thisChk.id);
        if (bolIsPressShift === true) {
            if (MultipleSelectGvCheck(strCtrlId) == true) {
                if (td_parent != null) {
                    td_parent.className = "bg-primary";
                    Update(strCtrlId);
                }
            }
            else {
                if (td_parent != null) {
                    td_parent.className = "";
                }
            }
        }
        else {
            if (SingleSelectGvCheck(strCtrlId, 'gvFeatureRegionFlds') == true) {
                if (td_parent != null) {
                    td_parent.className = "bg-primary";
                    Update(strCtrlId);
                }
            }
            else {
                if (td_parent != null) {
                    td_parent.className = "";
                }
            }
        }
    }
    
    function btn_Click(strCtrlId, event) {
        event = window.event || event;
        var bolIsPressShift = false;
        if (event.shiftKey == 1) {
            bolIsPressShift = true;
            console.log("shift被按下了, strCtrlId:" + strCtrlId)
        }
        else {
            bolIsPressShift = false;
            console.log("shift没被按下,strCtrlId:" + strCtrlId)
        }
        var thisChk = event.target;

        console.log(thisChk);
        //alert(thisChk.id);
         var td_parent;
        //if (thisChk.localName == "input") {
        //    td_parent = thisChk.parentNode;
        //    console.log(td_parent);
        //}
        //alert(thisChk.id);
        if (bolIsPressShift === true) {
            if (MultipleSelectGvCheck(strCtrlId) == true) {
                thisChk.className = "btn btn-info btn-sm text-nowrap border-secondary";
                Update(strCtrlId);
            }
            else {
                thisChk.className = "btn btn-outline-info btn-sm text-nowrap";
            }
        }
        else {
            if (SingleSelectGvCheck(strCtrlId, 'gvFeatureRegionFlds') == true) {
                thisChk.className = "btn btn-info btn-sm text-nowrap border-secondary";
                Update(strCtrlId);
            }
            else {
                thisChk.className = "btn btn-outline-info btn-sm text-nowrap";
            }
        }
    }
    function ddl_Click(strCtrlId, event) {
          event = window.event || event;
        var bolIsPressShift = false;
        if (event.shiftKey == 1) {
            bolIsPressShift = true;
            console.log("shift被按下了, strCtrlId:" + strCtrlId)
        }
        else {
            bolIsPressShift = false;
            console.log("shift没被按下,strCtrlId:" + strCtrlId)
        }
        var thisChk = event.target;

        console.log(thisChk);
        //alert(thisChk.id);
        if (bolIsPressShift === true) {
            if (MultipleSelectGvCheck(strCtrlId) == true) {
                thisChk.className = "bg-primary";
            }
            else {
                thisChk.className = "";
            }
        }
        else {
            if (SingleSelectGvCheck(strCtrlId, 'gvFeatureRegionFlds') == true) {
                thisChk.className = "bg-primary";
            }
            else {
                thisChk.className = "";
            }
        }
    }
    function chk_Click(strCtrlId, event) {
          event = window.event || event;
        var bolIsPressShift = false;
        if (event.shiftKey == 1) {
            bolIsPressShift = true;
            console.log("shift被按下了, strCtrlId:" + strCtrlId)
        }
        else {
            bolIsPressShift = false;
            console.log("shift没被按下,strCtrlId:" + strCtrlId)
        }
        var thisChk = event.target;

        console.log(thisChk);
        var spn_parent;
        if (thisChk.localName == "span") {
            spn_parent = thisChk.parentNode;
            console.log(spn_parent);
        }
        //alert(thisChk.id);
        if (bolIsPressShift === true) {
            if (MultipleSelectGvCheck(strCtrlId) == true) {
                if (spn_parent != null) {
                    spn_parent.className = "bg-primary";
                }
            }
            else {
                if (spn_parent != null) {
                    spn_parent.className = "";
                }
            }
        }
        else {
             if (SingleSelectGvCheck(strCtrlId, 'gvFeatureRegionFlds') == true) {
                if (spn_parent != null) {
                    spn_parent.className = "bg-primary";
                }
            }
            else {
                if (spn_parent != null) {
                    spn_parent.className = "";
                }
            }
        }
    }

</script>
<div id="divFeatureRegion4Preview" class="border border-danger" runat="server">
    
    <ul class="nav">
        <li class="nav-item">
            <asp:Label ID="lblTitle" runat="server" Text="可视化" CssClass="text-warning"></asp:Label>
            <asp:Label ID="lblTitleOutUse" runat="server" Width="150px" Text="功能区域不使用" CssClass="text-warning"></asp:Label>

        </li>
        <li class="nav-item ml-2">
            <asp:Panel ID="pnlControlLst" runat="server">
            </asp:Panel>
        </li>
    </ul>
</div>



