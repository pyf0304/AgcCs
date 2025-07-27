/// <reference path="jsGetElement.js" />
//版本：20170708
//作者：潘以锋
/// <reference path="jsString.js" />
/// <reference path="tzStringFormat.js" />
var VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中

include(VirtualRootPath + "/js/PubFun/jsPubFun.js")
include(VirtualRootPath + "/js/PubFun/jsString.js")
include(VirtualRootPath + "/js/PubFun/tzStringFormat.js")
include(VirtualRootPath + "/js/PubFun/jsGetElement.js")

//文本框的包装类
var TzTextBox = function (strId) {
    this.Text = "";
    this.Id = strId || "";
    this.setId = function (strId) {
        this.Id = strId;
    }
    //检查待查找的控件Id
    this.checkId = function () {
        if (this.Id === "") {
            throw "文本框的控件Id为空，不能进行该控件的操作！";
        }
    }
    this.getElement = function()
    {
        var myText = getObjByTagAndId("input", this.Id);
        if (myText === null || myText === undefined) {
            var strMsg = String.format("Id:[{0}]的文本框不存在，请检查！", this.Id);
            throw strMsg;            
        }
        return myText;
    }
    this.getText = function () {
        try {
            this.checkId();
            var myText = this.getElement();

            var strValue = myText.value;
            return strValue;
        }

        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
    this.setText = function (strValue) {
        try {
            this.checkId();
            var myText = this.getElement();
            myText.value = strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return ;
        }
    }

    //隐藏文本(Input)对象
    this.Hide = function () {
        try {
            this.checkId();
            var myText = this.getElement();

            myText.style.display = 'none';
            myText.style.visibility = "hidden";//隐藏      
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }

    }

    //显示文本(Input)对象
    this.Show = function () {
        try {
            this.checkId();
            var myText = this.getElement();
            myText.style.display = 'block';
            myText.style.visibility = "visible";//显示
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }

    }
}


//文本框的包装类
var TzTextArea = function (strId) {
    this.Text = "";
    this.Id = strId || "";
    this.setId = function (strId) {
        this.Id = strId;
    }
    //检查待查找的控件Id
    this.checkId = function () {
        if (this.Id === "") {
            throw "多行文本框的控件Id为空，不能进行该控件的操作！";
        }
    }
    this.getElement = function () {
        var myText = getObjByTagAndId("textarea", this.Id);
        if (myText === null || myText === undefined) {
            var strMsg = String.format("Id:[{0}]的多行文本框不存在，请检查！", this.Id);
            throw strMsg;
        }
        return myText;
    }
    this.getText = function() {
        try {
            this.checkId();
            var myText = this.getElement();

            var strValue = myText.value;
            return strValue;
        }
        catch(e){
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
    this.setText = function(strValue) {
        try {
            this.checkId();
            var myText = this.getElement();
            myText.value = strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else
            {
                alert(e);
            }
            return;
        }
    }

    //隐藏文本(Input)对象
    this.Hide = function(){
        try {
            this.checkId();
            var myText = this.getElement();
            myText.style.display = 'none';
            myText.style.visibility = "hidden";//隐藏      
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }

    //显示文本(Input)对象
    this.Show = function () {
        try {
            this.checkId();
            var myText = this.getElement();
            myText.style.display = 'block';
            myText.style.visibility = "visible";//显示
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }

    }
}

//下拉框的包装类
var TzSelect = function (strId) {

    this.Id = strId || "";
    this.setId = function(strId)
    {
        this.Id = strId;
    }
    //检查待查找的控件Id
    this.checkId = function () {
        if (this.Id === "") {
            throw "下拉框的控件Id为空，不能进行该控件的操作！";
        }
    }
    this.getElement = function()
    {
        var mySelect = getObjByTagAndId("select", this.Id);
        if (mySelect === null || mySelect === undefined) {
            var strMsg = String.format("Id:[{0}]的下拉框不存在，请检查！", this.Id);
            throw strMsg;            
        }
        return mySelect;
    }
    this.getSelectedText = function () {
        try
        {
            this.checkId();
            var mySelect = this.getElement();
            var strSelectedText = mySelect.options[mySelect.selectedIndex].text;
            return strSelectedText;
        }
        catch(e)
        {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
    this.getSelectedValue = function () {
        try
        {
            this.checkId();
            var mySelect = this.getElement();
            var strSelectedValue = mySelect.options[mySelect.selectedIndex].value;
            return strSelectedValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
    this.RemoveAll = function()
    {
        try
        {
            this.checkId();
            var mySelect = this.getElement();

            var intLen = mySelect.options.length;
            for (var i = intLen - 1; i >= 0; i--) {
                mySelect.options.remove(i);
            }
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }
    this.AddItems = function AddItems(strValue, strText) {
        try
        {
            this.checkId();
            var mySelect = this.getElement();

            mySelect.options.add(new Option(strText, strValue));
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }

    this.SetSelectedItem = function (strValue) {
        try
        {
            this.checkId();
            var mySelect = this.getElement();
            for (var i = 0; i < mySelect.options.length; i++) {
                if (mySelect.options[i].value === strValue) {
                    mySelect.options[i].selected = true;
                    return;
                }
            }
            var strMsg = String.format("Id:[{0}]的下拉框中值:[{1}]不存在，请检查！",
                this.Id, strValue);
            alert(strMsg);
            return;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }

    this.SetSelectedItemByIndex = function (intIndex) {
        try
        {
            var strMsg = "";
            this.checkId();
            var mySelect = this.getElement();
            if (intIndex < 0) {
                strMsg = String.format("下拉框的选项，不能设置为小于0的选项,请检查！");
                alert(strMsg);
                return;
            }
            if (intIndex >= mySelect.options.length) {
                strMsg = String.format("Id:[{0}]的下拉框只有[{1}]个选项，不能设置为：[{2}],请检查！",
                    this.Id, mySelect.options.length, intIndex);
                alert(strMsg);
                return;
            }

            mySelect.options[intIndex].selected = true;
            return;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }
    //隐藏文本(Input)对象
    this.Hide = function () {
        try
        {
            this.checkId();
            var mySelect = this.getElement();

            mySelect.style.display = 'none';
            mySelect.style.visibility = "hidden";//隐藏        
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }

    //显示文本(Input)对象
    this.Show = function () {
        try
        {
            this.checkId();
            var mySelect = this.getElement();
            mySelect.style.display = 'block';
            mySelect.style.visibility = "visible";//显示
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }
}

//层(Div)的包装类
var TzDiv = function (strId) {
    this.Text = "";
    this.Id = strId || "";
    var myGetElement = new tzGetElement(strId);
    this.setId = function (strId) {
        this.Id = strId;
    }
    //检查待查找的控件Id
    this.checkId = function () {
        if (this.Id === "") {
            throw "Div的控件Id为空，不能进行该控件的操作！";
        }
    }
    this.getElement = function () {
        myGetElement.setTagType("div");
        var myDiv = myGetElement.getFstObjByTagAndId();
        if (myDiv === null || myDiv === undefined) {
            var strMsg = String.format("Id:[{0}]的层(div)不存在，请检查！", this.Id);
            throw strMsg;
        }
        return myDiv;
    }
    //获取坐标位置  
    function getpos(e) {
        var t = e.offsetTop;
        var l = e.offsetLeft;
        var height = e.offsetHeight;
        e = e.offsetParent;
        while (e) {
            t += e.offsetTop;
            l += e.offsetLeft;
            e = e.offsetParent;
        }
        var strLeftTop = l.toString() + "," + t.toString();
        return strLeftTop;
    }

    this.RemoveThis = function () {
        try
        {
            this.checkId();
            var myDiv = this.getElement();     
      
            var objParentDiv = myDiv.parentNode;
            if (objParentDiv !== null) {
                objParentDiv.removeChild(myDiv);
            }
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return ;
        }
    }

    //document.getElementById("控件ID").style.visibility = "hidden";
    //document.getElementById("控件ID").style.visibility = "visible";
    //document.getElementById("控件ID").style.display = "none";
    //document.getElementById("控件ID").style.display = "inline";


    //隐藏层(div)对象
    this.Hide = function () {
        try {
            this.checkId();
            var myDiv = this.getElement();

            myDiv.style.display = 'none';
            myDiv.style.visibility = "hidden";//隐藏  
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }

    //显示层(div)对象
    this.Show = function() {
        try {
            this.checkId();
            var myDiv = this.getElement();
            myDiv.style.display = 'block';
            myDiv.style.visibility = "visible";//显示   
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }
    this.setLeft = function (intLeft) {
        try {
            this.checkId();
            var myDiv = this.getElement();

            myDiv.style.position = 'absolute';
            myDiv.style.left = intLeft + "px";//显示  
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }
    this.setTop = function (intTop) {
        try {
            this.checkId();
            var myDiv = this.getElement();

            myDiv.style.position = 'absolute';
            myDiv.style.Top = intTop + "px";//显示    
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }
    //设置位置
    this.setPos = function (intLeft, intTop) {
        try {
            this.checkId();
            var myDiv = this.getElement();


            myDiv.style.position = 'absolute';
            myDiv.style.left = intLeft + "px";//显示        
            myDiv.style.top = intTop + "px";//显示     
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }
    this.appendChild = function(obj)
    {
        try {
            this.checkId();
            var myDiv = this.getElement();

            myDiv.appendChild(obj);
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }
}


//隐藏字段的包装类
var TzSpan = function (strId) {
    this.value = "";
    this.Id = strId || "";
    var myGetElement = new tzGetElement(strId);
    this.setId = function (strId) {
        this.Id = strId;
    }
    //检查待查找的控件Id
    this.checkId = function () {
        if (this.Id === "") {
            throw "span(Label)的控件Id为空，不能进行该控件的操作！";
        }
    }
    this.getElement = function () {
        myGetElement.setTagType("span");
        var myText = myGetElement.getFstObjByTagAndId();
        if (myText === null || myText === undefined) {
            var strMsg = String.format("Id:[{0}]的span(Label)不存在，请检查！", this.Id);
            throw strMsg;
        }
        return myText;
    }
    this.getinnerText = function () {
        try {
            this.checkId();
            var myText = this.getElement();

            var strValue = myText.innerText;
            return strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
    this.setinnerText = function (strValue) {
        try {
            this.checkId();
            var myText = this.getElement();
            myText.innerText = strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }

    this.getinnerHTML = function () {
        try {
            this.checkId();
            var myText = this.getElement();

            var strValue = myText.innerHTML;
            return strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
    this.setinnerHTML = function (strValue) {
        try {
            this.checkId();
            var myText = this.getElement();
            myText.innerHTML = strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }
}


//隐藏字段的包装类
var TzHiddenField = function (strId) {
    this.Text = "";
    this.Id = strId || "";
    var myGetElement = new tzGetElement(strId);
    this.setId = function (strId) {
        this.Id = strId;
    }
    //检查待查找的控件Id
    this.checkId = function () {
        if (this.Id === "") {
            throw "HiddenField的控件Id为空，不能进行该控件的操作！";
        }
    }
    this.getElement = function () {
        myGetElement.setTagType("input");
        var myText = myGetElement.getFstObjByTagAndId();
        if (myText === null || myText === undefined) {
            var strMsg = String.format("Id:[{0}]的HiddenField不存在，请检查！", this.Id);
            throw strMsg;
        }
        return myText;
    }
    this.getValue = function () {
        try {
            this.checkId();
            var myText = this.getElement();

            var strValue = myText.value;
            return strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
    this.setValue = function (strValue) {
        try {
            this.checkId();
            var myText = this.getElement();
            myText.value = strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }
}


//表table)的包装类
var TzTable = function (strId) {
    this.Id = strId || "";
    this.setId = function (strId) {
        this.Id = strId;
    }
    var myGetElement = new tzGetElement(strId);
    //检查待查找的控件Id
    this.checkId = function () {
        if (this.Id === "") {
            throw "Table的控件Id为空，不能进行该控件的操作！";
        }
    }
    this.getElement = function () {
        myGetElement.setTagType("table");
        var myTable = myGetElement.getFstObjByTagAndId();
        if (myTable === null || myTable === undefined) {
            var strMsg = String.format("Id:[{0}]的Table不存在，请检查！", this.Id);
            throw strMsg;
        }
        return myTable;
    }
    this.Hide = function () {
        try {
            this.checkId();
            var myTable = this.getElement();
            myTable.style.display = 'none';
            myTable.style.visibility = "hidden";//隐藏    
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }
    }

    this.Show = function () {
        try
        {
            this.checkId();
            var myTable = this.getElement();
        myTable.style.display = 'inline';
        myTable.style.visibility = "visible";//显示             
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }
    }
    this.insertRow = function () {
        try
        {
            this.checkId();
            var myTable = this.getElement();
            var tr = myTable.insertRow();
            var objTr = new TzTr();
            objTr.setObjTr(tr);
            return objTr;
            //var td = tr.insertCell();
            //tr.setAttribute('align', 'center');  //'不用setAttribute而直接使用属性也可以.
            //tr.setAttribute('bgcolor', '#FF0000')
            //td.width = 100;   //'直接对属性赋值的作法.
            //td.innerText = "aaa";
        }
        catch(e)
        {
            alert(e.message);
        }

    }

    this.deleteRow = function (intIndex) {    //alert(trid);
        try {
            this.checkId();
            var myTable = this.getElement();
            if (intIndex <= myTable.rows.length - 1)
            {
                myTable.deleteRow(intIndex);  //从table中删除
            }
            else
            {
                var strMsg = String.format("表格待删除的序号:[{0}]超出表的行数:[{1}]。",
                    intIndex, myTable.rows.length);
                throw strMsg;
            }            
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }
        //var tab = document.getElementByIdx_x("signFrame");
        //var row = document.getElementByIdx_x(trid);
        //var index = row.rowIndex;//rowIndex属性为tr的索引值，从0开始  
        //tab.deleteRow(index);  //从table中删除

        ////重新排列序号，如果没有序号，这一步省略
        //var nextid;
        //for (i = index; i < tab.rows.length; i++) {
        //    tab.rows[i].cells[0].innerHTML = i.toString();
        //    nextid = i + 1;
        //    remark = document.getElementByIdx_x("remark" + nextid);
        //    remark.id = "remark";
        //}
    }
    this.getLength = function()
    {
        try {
            this.checkId();
            var myTable = this.getElement();
            return myTable.rows.length;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }
    }
}

//表行(Tr)的包装类
var TzTr = function (strId) {
    this.Id = strId || "";
    this.objTr = null;
    this.setId = function (strId) {
        this.Id = strId;
    }
    this.setObjTr = function (pObjTr) {
        this.objTr = pObjTr;
    }

    var myGetElement = new tzGetElement(strId);
    //检查待查找的控件Id
    this.checkId = function () {
        if (this.Id === "") {
            throw "Tr的控件Id为空，不能进行该控件的操作！";
        }
    }
    this.getElement = function () {
        if (this.objTr !== null) return this.objTr;
        this.checkId();
        myGetElement.setTagType("tr");
        var myTr = myGetElement.getFstObjByTagAndId();
        if (myTr === null || myTr === undefined) {
            var strMsg = String.format("Id:[{0}]的Tr不存在，请检查！", this.Id);
            throw strMsg;
        }
        return myTr;
    }
    this.Hide = function () {
        try {
            this.checkId();
            var myTr = this.getElement();

            myTr.style.display = 'none';
            myTr.style.visibility = "hidden";//隐藏    
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }
    }

    this.Show = function () {
        try {
            this.checkId();
            var myTr = this.getElement();

            myTr.style.display = 'inline';
            myTr.style.visibility = "visible";//显示 
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }
    }

    this.insertCell = function (strText) {
        try {         
            var myTr = this.getElement();          
            var td = myTr.insertCell();
            if (arguments.length > 0) {
                if (strText !== null && strText !== "") {
                    td.innerText = strText;
                }
            }
            var objTd = new TzTd();
            objTd.setObjTd(td);
            return objTd;
            //tr.setAttribute('align', 'center');  //'不用setAttribute而直接使用属性也可以.
            //tr.setAttribute('bgcolor', '#FF0000')
            //td.width = 100;   //'直接对属性赋值的作法.
            //td.innerText = "aaa";
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }

    }
}


//表行(Td)的包装类
var TzTd = function (strId) {
    this.Id = strId || "";
    this.objTd = null;
    this.setId = function (strId) {
        this.Id = strId;
    }
    this.setObjTd = function (pObjTd) {
        this.objTd = pObjTd;
    }

    var myGetElement = new tzGetElement(strId);
    //检查待查找的控件Id
    this.checkId = function () {
        if (this.Id === "") {
            throw "Td的控件Id为空，不能进行该控件的操作！";
        }
    }
    this.getElement = function () {
        if (this.objTd !== null) return this.objTd;
        this.checkId();
        myGetElement.setTagType("td");
        var myTd = myGetElement.getFstObjByTagAndId();
        if (myTd === null || myTd === undefined) {
            var strMsg = String.format("Id:[{0}]的Td不存在，请检查！", this.Id);
            throw strMsg;
        }
        return myTd;
    }
    this.Hide = function () {
        try {
            
            var myTd = this.getElement();
            myTd.style.display = 'none';
            myTd.style.visibility = "hidden";//隐藏    
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }
    }

    this.Show = function () {
        try {           
            var myTd = this.getElement();
            myTd.style.display = 'inline';
            myTd.style.visibility = "visible";//显示 
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }
    }

    this.setText = function (strText) {
        try {          
            var myTd = this.getElement();
            myTd.innerText = strText;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }
    }
    this.appendChild = function(obj)
    {
        try {
            var myTd = this.getElement();
            myTd.appendChild(obj);
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }
    }
    this.setHTML = function (strHTML) {
        try {
            var myTd = this.getElement();
            myTd.innerHTML = strHTML;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }
    }
    this.setWidth = function (intWidth) {
        try {
        
            var myTd = this.getElement();
            myTd.width = intWidth;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
        }

    }
}


//按钮的包装类
var TzButton = function (strId) {
    this.Text = "";
    this.Id = strId || "";
    this.objButton = null;

    this.setId = function (strId) {
        this.Id = strId;
    }
    this.getObj = function()
    {
        if (this.objButton !== null) return this.objButton;
        try {
            this.checkId();
            var myButton = this.getElement();
            return myButton;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
    //检查待查找的控件Id
    this.checkId = function () {
        if (this.Id === "") {
            throw "文本框的控件Id为空，不能进行该控件的操作！";
        }
    }
    this.getElement = function () {
        var myButton = getObjByTagAndId("input", this.Id);
        if (myButton === null || myButton === undefined) {
            var strMsg = String.format("Id:[{0}]的文本框不存在，请检查！", this.Id);
            throw strMsg;
        }
        return myButton;
    }
    this.getText = function () {
        try {
            this.checkId();
            var myButton = this.getElement();

            var strValue = myButton.value;
            return strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
    this.setText = function (strValue) {
        try {
            this.checkId();
            var myButton = this.getElement();
            myButton.value = strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }

    //隐藏文本(Input)对象
    this.Hide = function () {
        try {
            this.checkId();
            var myButton = this.getElement();

            myButton.style.display = 'none';
            myButton.style.visibility = "hidden";//隐藏      
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }

    }

    //显示文本(Input)对象
    this.Show = function () {
        try {
            this.checkId();
            var myButton = this.getElement();
            myButton.style.display = 'block';
            myButton.style.visibility = "visible";//显示
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }

    }
    this.click = function () {
        try {
            this.checkId();
            var myButton = this.getElement();
            myButton.click();
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
}



//按钮的包装类
var TzA = function (strId) {
    this.Text = "";
    this.Id = strId || "";
    this.objA = null;

    this.setId = function (strId) {
        this.Id = strId;
    }
    this.getObj = function () {
        if (this.objA !== null) return this.objA;
        try {
            this.checkId();
            var myA = this.getElement();
            return myA;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
    //检查待查找的控件Id
    this.checkId = function () {
        if (this.Id === "") {
            throw "超链接(a)的控件Id为空，不能进行该控件的操作！";
        }
    }
    this.getElement = function () {
        var myA = getObjByTagAndId("a", this.Id);
        if (myA === null || myA === undefined) {
            var strMsg = String.format("Id:[{0}]的超链接(a)不存在，请检查！", this.Id);
            throw strMsg;
        }
        return myA;
    }
    this.getText = function () {
        try {
            this.checkId();
            var myA = this.getElement();

            var strValue = myA.value;
            return strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
    this.setText = function (strValue) {
        try {
            this.checkId();
            var myA = this.getElement();
            myA.value = strValue;
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }
    }

    //隐藏文本(Input)对象
    this.Hide = function () {
        try {
            this.checkId();
            var myA = this.getElement();
            myA.style.display = 'none';
            myA.style.visibility = "hidden";//隐藏      
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }

    }

    //显示文本(Input)对象
    this.Show = function () {
        try {
            this.checkId();
            var myA = this.getElement();
            myA.style.display = 'block';
            myA.style.visibility = "visible";//显示
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return;
        }

    }
    this.click = function () {
        try {
            this.checkId();
            var myA = this.getElement();
            myA.click();
        }
        catch (e) {
            if (e.message) {
                alert(e.message);
            }
            else {
                alert(e);
            }
            return "";
        }
    }
}