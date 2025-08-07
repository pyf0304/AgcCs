//选择某一控件，使该控件处于选择状态
function SelectOneCtrl(objCtrl) {
    switch (objCtrl.localName) {
        case "select":
            objCtrl.className = "form-control  border-danger"
            break;
        case "input":
            if (objCtrl.type == "checkbox") {
                spn_parent = objCtrl.parentNode;
                if (spn_parent != null) {
                    spn_parent.className = "form-control border-danger";
                }
            } else if (objCtrl.type == "button") {               
                objCtrl.className = "btn btn-info btn-sm text-nowrap border-secondary";               
            }
            else {
                objCtrl.className = "form-control  border-danger"
            }
            break;
        case "span":
            objCtrl.className = "text-danger"            
            break;
    }
}