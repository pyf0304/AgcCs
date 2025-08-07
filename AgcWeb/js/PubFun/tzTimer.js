var myVar;
function startTimer() {
    /*setInterval() 间隔指定的毫秒数不停地执行指定的代码*/
    myVar = setInterval(function () { myTimer() }, 1000);
}
function myTimer()/* 定义一个得到本地时间的函数*/ {
    var d = new Date();
    var t = d.toLocaleTimeString();
    document.getElementById("demo").innerHTML = t;
}
function stopTimer() {/* clearInterval() 方法用于停止 setInterval() 方法执行的函数代码*/
    clearInterval(myVar);
}