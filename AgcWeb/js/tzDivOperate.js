//版本1.0
//作者：潘以锋
//日期：2017-5-31

var xx, yy;
var divCurrMove;
var moveflag = false;//移动标志
//div4Move需要移动的层
function setMouseEvent4Move(div4Move) {
    
    div4Move.onmousedown = myonmousedown;
    //      document.documentElement.onmousemove = myonmousemove;
    div4Move.onmousemove = myonmousemove;
    div4Move.onmouseup = myonmouseup;
  
}
function myonmousedown(event) {
    //Console.log(event);
    var event1 = event || window.event;                  // IE、火狐获取事件对象
    var mouseX1;
    var mouseY1;
    mouseX1 = event1.clientX;         // 获取鼠标相对于事件源的X轴
    mouseY1 = event1.clientY;        // 获取鼠标相对于事件源的Y轴
    var div1 = document.getElementById("div1");
    var oldLeft = parseInt(div1.style.left);
    var oldTop = parseInt(div1.style.top);
    xx = mouseX1 - oldLeft;
    yy = mouseY1 - oldTop;
    console.log("mouse:" + mouseX1 + " " + mouseY1)
    console.log("div:" + oldLeft + " " + oldTop)
    console.log(xx + " " + yy)

    //        var flag = true;
    //            mouseX1 = event.clientX;
    //          mouseY1 = event.clientY;
    moveflag = true;
    divCurrMove = this;
    //alert("myonmousemove" + mouseX.toString());
}

function myonmousemove(event) {
    //Console.log(event);

    var event2 = event || window.event;
    var mouseX2 = event2.clientX;             // 获取鼠标相对于浏览器x轴的位置
    var mouseY2 = event2.clientY;             // 获取鼠标相对于浏览器Y轴的位置

    //alert("myonmousemove" + mouseX.toString());
    if (moveflag === true) {
        //var div1 = document.getElementById("div1");


        divCurrMove.style.left = mouseX2 - xx + "px";
        divCurrMove.style.top = mouseY2 - yy + "px";
        divCurrMove.style.position = "absolute";
        //var div2 = document.getElementById("div2");
        //div2.innerHTML = div1.style.left + ":" + div1.style.top + "<br/>";
        //div2.innerHTML += "xx:" + xx.toString();
        //div2.innerHTML += " yy:" + yy.toString() + "<br/>";
        //div2.innerHTML += "mouseX2:" + mouseX2.toString();
        //div2.innerHTML += " mouseY2:" + mouseY2.toString() + "<br/>";
    }
}
function myonmouseup(event) {

    moveflag = false;
    console.log("myonmouseup:" + moveflag);
    //            alert("flag = false;");
}


function Tz_ShowDiv(strDivName) {

    var objDiv = getObjByTagAndId("div", strDivName);
    if (objDiv === null) return;

    if (objDiv) {

        //objDiv4SelectFile.style.float = "center";
        //objDiv4SelectFile.style.border = "1px";
        objDiv.style.display = 'block';
        objDiv.style.visibility = "visible";//显示


    }
    //alert(objDiv4SelectFile);
}

function Tz_HideDiv(strDivName) {

    var objDiv = getObjByTagAndId("div", strDivName);
    if (objDiv === null) return;
    if (objDiv) {
        objDiv.style.display = 'none';
        objDiv.style.visibility = "hidden";//隐藏        
    }
    //alert(objDiv4SelectFile);
}
