<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucQryRegion4Preview.ascx.cs"
    Inherits="AGC.Webform.wucQryRegion4Preview" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<script src="../../js/tzGridView.js"></script>
<script src="../../js/tzCtrl.js"></script>
<script>
    Array.prototype.contains1 = function (id) {
        var i = this.length;
        while (i--) {
            if (id.indexOf(this[i]) > -1) {
                return true;
            }
        }
        return false;
    }
    function ReSelectCtrl() {
        var arrCtrlId = GetCheckedItems4Gv('gvQryRegionFlds');
        if (arrCtrlId == null) {
            return;
        }
        var arrDiv0 = document.getElementsByTagName("div");
        var arrDiv = GetArray(arrDiv0);
        arrDiv = arrDiv.filter(x => x.id.indexOf('pnlControlLst') > -1);
        if (arrDiv.length == 0) {
            alert('在当前界面中没有找到Div:pnlControlLst. (In ReSelectCtrl of wucQryRegion4Preview.ascx) ');
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
        var ContentPlaceHolder1_btnUpdate4Dg = document.getElementById('ContentPlaceHolder1_btnUpdate4Dg');
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
        if (ContentPlaceHolder1_btnUpdate4Dg != null) {
            ContentPlaceHolder1_btnUpdate4Dg.click();
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
        if (bolIsPressShift === true) {
            if (MultipleSelectGvCheck(strCtrlId) == true) {
                thisChk.className = "form-control  border-danger";
                Update(strCtrlId);
            }
            else {
                thisChk.className = "form-control";
            }
        }
        else {
                        if (SingleSelectGvCheck(strCtrlId, 'gvQryRegionFlds') == true) {
                thisChk.className = "form-control  border-danger";
                Update(strCtrlId);
            }
            else {
                thisChk.className = "form-control";
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
                thisChk.className = "form-control  border-danger";
                Update(strCtrlId);
            }
            else {
                thisChk.className = "form-control";
            }
        }
        else {
            if (SingleSelectGvCheck(strCtrlId, 'gvQryRegionFlds') == true) {
                thisChk.className = "form-control  border-danger";
                Update(strCtrlId);
            }
            else {
                thisChk.className = "form-control";
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
        if (thisChk.type == "checkbox") {
            spn_parent = thisChk.parentNode;
            console.log(spn_parent);
        }
        //alert(thisChk.id);
        if (bolIsPressShift === true) {
            if (MultipleSelectGvCheck(strCtrlId) == true) {
                if (spn_parent != null) {
                    spn_parent.className = "form-control border-danger";
                    Update(strCtrlId);
                }
            }
            else {
                if (spn_parent != null) {
                    spn_parent.className = "form-control";
                }
            }
        }
        else {
            if (SingleSelectGvCheck(strCtrlId, 'gvQryRegionFlds') == true) {
                if (spn_parent != null) {
                    spn_parent.className = "form-control border-danger";
                    Update(strCtrlId);
                }
            }
            else {
                if (spn_parent != null) {
                    spn_parent.className = "form-control";
                }
            }
        }
    }

</script>
<div id="divQryRegion4Preview" runat="server" class="border border-danger">
    <div>
        <asp:Label ID="lblTitle" runat="server" Text="可视化" Width="100px" CssClass="text-warning"></asp:Label>
        <asp:Label ID="lblTitleOutUse" runat="server" Width="150px" Text="查询区域不使用" CssClass="text-warning"></asp:Label>
    </div>
    <div>
        <asp:Panel ID="pnlControlLst" runat="server">
        </asp:Panel>
    </div>

</div>
