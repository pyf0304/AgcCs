function OpenwfmDispSqlData(strTabId) {

    var url = window.location.href;
    //var caseid = document.all.ctl00_ContentPlaceHolder1_hidId_ClsRmTeachingCase.value; //  url.substring(url.indexOf('id=') + 3, url.length);
    window.open('../CommonPage/wfmDispSqlData.aspx?TabId=' + strTabId + '', '', 'width=1020px,height=800px,top=100px,left=150px,scrollbars=yes');
}


function OpenwfmTabFieldRela(strTabId) {

    var url = window.location.href;
    //var caseid = document.all.ctl00_ContentPlaceHolder1_hidId_ClsRmTeachingCase.value; //  url.substring(url.indexOf('id=') + 3, url.length);
    window.open('wfmTabFieldRelaB_QUDI.aspx?TabId=' + strTabId + '', '', 'width=1020px,height=800px,top=100px,left=150px,scrollbars=yes');
}

function showReplaceFldDiv(divName) {

  
    var intRefPositionX ;
    var intRefPositionY ;
    intRefPositionX = 750;
    intRefPositionY = 300;
    var strMsg1 = "源左：" + intRefPositionX.toString() + " 源顶：" + intRefPositionY.toString();
    alert(strMsg1);

    var divTooltip = getObjByTagAndId("div", divName);
  


    if (divTooltip) {
        if (divTooltip.style.display === 'block') {

        } else {


            var RightEdge = document.body.clientWidth - intRefPositionX;                    //获取当前鼠标右键按下后的位置，据此定义菜单显示的位置 
            var BottomEdge = document.body.clientHeight - intRefPositionY;

            //var strMsg2 = "RightEdge：" + RightEdge.toString() + " BottomEdge：" + BottomEdge.toString()
            //    + "  divTooltip.offsetWidth:" + divTooltip.offsetWidth.toString()
            //+ "  document.body.scrollLeft:" + document.body.scrollLeft.toString()
            //+ "  document.body.scrollTop:" + document.body.scrollTop.toString();
            //alert(strMsg2);
            var myLeft = 0;
            //if (RightEdge < divTooltip.offsetWidth)            //如果从鼠标位置到窗口右边的空间小于菜单的宽度，就定位菜单的左坐标（Left）为当前鼠标位置向左一个菜单宽度 
            //{
            //    myLeft = document.body.scrollLeft + intRefPositionX - divTooltip.offsetWidth;
            //}
            //else                                                                        //否则，就定位菜单的左坐标为当前鼠标位置
            //{
                myLeft = document.body.scrollLeft + intRefPositionX;
            //}
            divTooltip.style.left = myLeft.toString() + "px";
                 alert("left000:" + divTooltip.style.left + "  myLeft:" + myLeft.toString());
            var myscrollTop = document.body.scrollTop;
            if (myscrollTop == 0) {
                myscrollTop = document.documentElement.scrollTop;
            }
            var myTop = 0;
           
                myTop = myscrollTop + intRefPositionY;
           
              
                divTooltip.style.top = myTop.toString() + "px";
                alert("divTooltip.style.top:" + divTooltip.style.top + "  myTop:" + myTop.toString());
            ////divTooltip.style.left = "0px";
            //divTooltip.style.top = "400px";
            //var xxx = getObjByTagAndId("input", "xxx");
            //xxx.value = divTooltip.style.left;
            //var yyy = getObjByTagAndId("input", "yyy");
            //yyy.value = divTooltip.style.top;

            divTooltip.style.display = 'block';
            divTooltip.style.visibility = "visible";//显示

        }
    }
}
