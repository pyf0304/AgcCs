var T_Async = function () {

    this.resolveAfter2Seconds = function (x) {
        return new Promise(resolve => {
            setTimeout(() => {
                resolve(x);
            }, 2000);
        });
    }

    this.add1 = async function (x) {
        var a = resolveAfter2Seconds(20);
        var b = resolveAfter2Seconds(30);
        return x + await a + await b;
    }

    //add1(10).then(v => {
    //    console.log(v);  // prints 60 after 2 seconds.
    //});
    
    //add2(10).then(v => {
    //    console.log(v);  // prints 60 after 4 seconds.
    //});
}
T_Async.add2 = async function (x) {
    var a = await resolveAfter2Seconds(20);
    var b = await resolveAfter2Seconds(30);
    return x + a + b;
}
