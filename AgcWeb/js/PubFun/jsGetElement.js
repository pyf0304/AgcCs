var tzGetElement = function (strFindId) {
    this.FindId = strFindId || "";
    this.FindName = "";
    this.FindId2 = "";
    this.TagType = "";
    this.setFindId = function (strFindId) {
        this.FindId = strFindId;
    }
    this.setFindId2 = function (strFindId2) {
        this.FindId2 = strFindId2;
    }

    this.setFindName = function (strFindName) {
        this.FindName = strFindName;
    }
    this.getTagTypeById = function () {
        var strFstThreeChar = this.FindId.substring(0, 3);
        if (strFstThreeChar === "txt") {
            return "input";
        }
        else if (strFstThreeChar === "ddl") {
            return "select";
        }
        else if (strFstThreeChar === "div") {
            return "div";
        }
        else if (strFstThreeChar === "lbl") {
            return "span";
        }
        else {
            return "";
        }
    }
    this.setTagType = function (strTagType) {
        this.TagType = strTagType;
    }
    //检查待查找的控件名
    this.checkFindName = function () {
        if (this.FindName === "") {
            throw "待查找的控件Name为空，不能在页面中获取该元素对象！";
        }
    }
    //检查待查找的控件Id
    this.checkFindId = function () {
        if (this.FindId === "") {
            throw "待查找的控件Id为空，不能在页面中获取该元素对象！";
        }
    }
    this.checkFindId2 = function () {
        if (this.FindId2 === "") {
            throw "待查找的控件Id2为空，不能在页面中获取该元素对象！";
        }
    }
    this.checkTagType = function () {
        if (this.TagType === "") {
            var strTagType = this.getTagTypeById();
            if (strTagType !== "") {
                this.TagType = strTagType;
            }
        }
        if (this.TagType === "") {
            throw "待查找元素的标签类型(TagType)为空，不能在页面中获取该元素对象！";
        }       
    }
    //在当前页面中，获取某名称Id，某标签(TagName)的对象
    this.getFstObjByTagAndId = function () {

        try {
            this.checkFindId();         
            this.checkTagType();

            var ObjList = document.forms[0].getElementsByTagName(this.TagType);

            for (var i = 0; i < ObjList.length; i++) {
                var varObjId = ObjList[i].id;
                if (varObjId.indexOf(this.FindId) >= 0) {
                    return ObjList[i];
                }
            }
            return null;
        }
        catch (e) {
            alert(e.message);
            return null;
        }
    }

    //在当前页面中，获取某名称开始的，某类型（type），某标签(TagName)的对象列表
    this.getObjLstByTagAndId = function () {
        try {
            this.checkFindId();          
            this.checkTagType();
            var objLst = document.getElementsByTagName(strTagName);
            var objTargetObjLst = new Array();
            for (var i = 0; i < objLst.length; i++) {
                var objT = objLst[i];
                var strObjId = objT.id;
                if (strObjId.indexOf(this.FindId) > -1) {
                    objTargetObjLst.push(objT);
                }
            }
            return objTargetObjLst;
        }
        catch (e) {
            alert(e.message);
            return null;
        }
    }

    //在当前页面中，获取某名称Id，名称Id2,某标签(TagName)的对象
    this.getFstObjByTagAndId2 = function () {
        try {
            this.checkFindId();
            this.checkFindId2();
            this.checkTagType();

            var ObjList = document.forms[0].getElementsByTagName(this.TagType);

            for (var i = 0; i < ObjList.length; i++) {
                var varObjId = ObjList[i].id;
                if (varObjId.indexOf(this.FindId) >= 0 && varObjId.indexOf(this.FindId2) >= 0) {
                    return ObjList[i];
                }
            }
            return null;

        }
        catch (e) {
            alert(e.message);
            return null;
        }
    }
    //在当前页面中，获取某名称，某标签(TagName)的对象值
    this.getFstObjByTagAndName = function () {
        try {
            this.checkFindName();
            this.checkTagType();
            var ObjList = document.forms[0].getElementsByTagName(this.TagType);

            for (var i = 0; i < ObjList.length; i++) {
                var varObjName = ObjList[i].name;
                if (varObjName.indexOf(this.FindName) >= 0) {
                    return ObjList[i];                    
                }
            }
            return null;
        }
        catch (e) {
            alert(e.message);
            return null;
        }
    }

    //在当前页面中，获取某名称，某标签(TagName)的对象值
    this.getFstObjValueByTagAndName = function () {
        try {
            this.checkFindName();
            this.checkTagType();
            var ObjList = document.forms[0].getElementsByTagName(this.TagType);

            for (var i = 0; i < ObjList.length; i++) {
                var varObjName = ObjList[i].name;
                if (varObjName.indexOf(this.FindName) >= 0) {
                    var varValue = ObjList[i].value;
                    return varValue;
                }
            }
            return "";
        }
        catch (e) {
            alert(e.message);
            return "";
        }
    }

    //在当前页面中，获取某名称，某标签(TagName)的对象值
    this.getFstObjValueByTagAndId = function () {
        try {
            this.checkFindId();
            this.checkTagType();
            var ObjList = document.forms[0].getElementsByTagName(this.TagType);

            for (var i = 0; i < ObjList.length; i++) {
                var varObjId = ObjList[i].id;
                if (varObjId.indexOf(this.FindId) >= 0) {
                    var varValue = ObjList[i].value;
                    return varValue;
                }
            }
            return "";
        }
        catch (e) {
            alert(e.message);
            return "";
        }
    }
    //在当前页面中，获取某名称Id，名称Id2,某标签(TagName)的对象
    this.getFstObjValueByTagAndId2 = function () {
        try {
            this.checkFindId();
            this.checkFindId2();
            this.checkTagType();

            var ObjList = document.forms[0].getElementsByTagName(this.TagType);

            for (var i = 0; i < ObjList.length; i++) {
                var varObjId = ObjList[i].id;
                if (varObjId.indexOf(this.FindId) >= 0 && varObjId.indexOf(this.FindId2) >= 0) {
                    var varValue = ObjList[i].value;
                    return varValue;
                }
            }
            return null;

        }
        catch (e) {
            alert(e.message);
            return null;
        }
    }
    
}
//在当前页面中，在对象列表中获取某名称Id的对象名
function getObjByObjListAndId(ObjList, varId) {
    //var ObjList = document.forms[0].getElementsByTagName(TagType);

    for (var i = 0; i < ObjList.length; i++) {
        var varObjId = ObjList[i].id;
        if (varObjId.indexOf(varId) >= 0) {
            return ObjList[i];
        }
    }
    return null;
}


//在当前页面中，获取某名称开始的，某类型（type），某标签(TagName)的对象列表
function GetObjectLstByTypeTagNameAndStartName(strType, strTagName, strStartName) {
    var objLst = document.getElementsByTagName(strTagName);
    var objTargetObjLst = new Array();
    for (var i = 0; i < objLst.length; i++) {
        var objT = objLst[i];
        var strObjName = objT.name;
        if (strObjName.indexOf(strStartName) > -1) {
            if (objT.type === strType) {
                objTargetObjLst.push(objT);
            }
        }
    }

    return objTargetObjLst;
}

//在当前页面中，获取某名称开始的，某类型（type），某标签(TagName)的对象列表
function GetObjectLstByTypeTagNameAndStartIdName(strType, strTagName, strStartIdName) {
    var objLst = document.getElementsByTagName(strTagName);
    var objTargetObjLst = new Array();
    for (var i = 0; i < objLst.length; i++) {
        var objT = objLst[i];
        var strObjId = objT.id;
        if (strObjId.indexOf(strStartIdName) > -1) {
            if (objT.type === strType) {
                objTargetObjLst.push(objT);
            }
        }
    }

    return objTargetObjLst;
}



//在当前页面中，获取某名称，某标签(TagName)的对象值
function getValueByObjListAndName(ObjList, varName) {
    //var ObjList = document.forms[0].getElementsByTagName(TagType);

    for (var i = 0; i < ObjList.length; i++) {
        var varObjName = ObjList[i].name;
        if (varObjName.indexOf(varName) >= 0) {
            var varValue = ObjList[i].value;
            return varValue;
        }
    }
    return "";
}
function getTagTypeById(strFindId) {
    var strFstThreeChar = strFindId.substring(0, 3);
    if (strFstThreeChar === "txt") {
        return "input";
    }
    else if (strFstThreeChar === "btn") {
        return "input";
    }
    else if (strFstThreeChar === "ddl") {
        return "select";
    }
    else if (strFstThreeChar === "div") {
        return "div";
    }
    else if (strFstThreeChar === "lbl") {
        return "span";
    }
    else {
        return "";
    }
}


//在当前页面中，获取某名称Id，某标签(TagName)的对象
function getObjByTagAndId(TagType, varId) {
    var ObjList = document.forms[0].getElementsByTagName(TagType);

    for (var i = 0; i < ObjList.length; i++) {
        var varObjId = ObjList[i].id;
        if (varObjId.indexOf(varId) >= 0) {
            return ObjList[i];
        }
    }
    return null;
}

//在当前页面中，获取某名称Id，某标签(TagName)的对象
function getObjByTagAndId2(TagType, varId1, varId2) {
    var ObjList = document.forms[0].getElementsByTagName(TagType);

    for (var i = 0; i < ObjList.length; i++) {
        var varObjId = ObjList[i].id;
        if (varObjId.indexOf(varId1) >= 0 && varObjId.indexOf(varId2) >= 0) {
            return ObjList[i];
        }
    }
    return null;
}

//在当前页面中，在对象列表中获取某名称Id的对象名
function getObjByObjListAndId(ObjList, varId) {
    //var ObjList = document.forms[0].getElementsByTagName(TagType);

    for (var i = 0; i < ObjList.length; i++) {
        var varObjId = ObjList[i].id;
        if (varObjId.indexOf(varId) >= 0) {
            return ObjList[i];
        }
    }
    return null;
}

//在当前页面中，获取某名称开始的，某类型（type），某标签(TagName)的对象列表
function GetObjectLstByTypeTagNameAndStartName(strType, strTagName, strStartName) {
    var objLst = document.getElementsByTagName(strTagName);
    var objTargetObjLst = new Array();
    for (var i = 0; i < objLst.length; i++) {
        var objT = objLst[i];
        var strObjName = objT.name;
        if (strObjName.indexOf(strStartName) > -1) {
            if (objT.type === strType) {
                objTargetObjLst.push(objT);
            }
        }
    }

    return objTargetObjLst;
}