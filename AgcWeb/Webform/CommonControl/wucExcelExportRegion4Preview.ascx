<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucExcelExportRegion4Preview.ascx.cs"
    Inherits="AGC.Webform.wucExcelExportRegion4Preview" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<script src="../../js/tzGridView.js"></script>
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
        var arrCtrlId = GetCheckedItems4Gv('gvExcelExportRegionFlds');

        if (arrCtrlId == null) {
            return;
        }
        var arrDiv0 = document.getElementsByTagName("div");
        var arrDiv = GetArray(arrDiv0);
        arrDiv = arrDiv.filter(x => x.id.indexOf('pnlControlLst') > -1);
        if (arrDiv.length == 0) {

            alert('在当前界面中没有找到Div:pnlControlLst. (In ReSelectCtrl of wucExcelExportRegion4Preview.ascx) ');

            return;
        }
        var divContainer = arrDiv[0];
        var arrspan0 = divContainer.getElementsByTagName('span');
        var arrspan = GetArray(arrspan0);
        console.log(arrspan);
        if (arrspan == null) return;
        arrspan = arrspan.filter(x => arrCtrlId.contains1(x.id));

        //arrspan.forEach(x => x.className = "bg-primary");
        var arrTd = arrspan.map(x => x.parentNode);
        arrTd = arrTd.filter(x => x != null);
        arrTd.forEach(x => x.className = "bg-primary");
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
            if (SingleSelectGvCheck(strCtrlId, 'gvExcelExportRegionFlds') == true) {
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
        if (thisChk.localName == "input") {
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
            if (SingleSelectGvCheck(strCtrlId, 'gvExcelExportRegionFlds') == true) {
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
                Update(strCtrlId);
            }
            else {
                thisChk.className = "";
            }
        }
        else {
            if (SingleSelectGvCheck(strCtrlId, 'gvExcelExportRegionFlds') == true) {
                thisChk.className = "bg-primary";
                Update(strCtrlId);
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
                    Update(strCtrlId);
                }
            }
            else {
                if (spn_parent != null) {
                    spn_parent.className = "";
                }
            }
        }
        else {
            if (SingleSelectGvCheck(strCtrlId, 'gvExcelExportRegionFlds') == true) {
                if (spn_parent != null) {
                    spn_parent.className = "bg-primary";
                    Update(strCtrlId);
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
<div id="divExcelExportRegion4Preview" class="border border-danger" runat="server">
    <div class="float-left" style="width:100%">
        <asp:Label ID="lblTitle" runat="server" Width="100px" Text="可视化" CssClass="text-warning"></asp:Label>
        <asp:Label ID="lblTitleOutUse" runat="server" Width="150px" Text="导出区域不使用" CssClass="text-warning"></asp:Label>
    </div>
    <div class="float-left">
        <asp:Panel ID="pnlControlLst" runat="server">
        </asp:Panel>
    </div>
</div>
