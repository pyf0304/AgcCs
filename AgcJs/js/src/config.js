/// <reference path="../../scripts/bootstrap.min.js" />
/// <reference path="../../scripts/popper.js" />
/// <reference path="../../scripts/jquery-3.4.1.min.js" />


"use strict";
requirejs.config({
    baseUrl: '../../',
    paths: {
        app: 'js/src/app',
        jquery: 'scripts/jquery-3.4.1.min',
        bootstrap: 'scripts/bootstrap.min',
        popper: 'scripts/umd/popper',
        tzdictionary: 'js/PubFun/tzDictionary',
        clscommfun4bl: 'js/PubFun/clsCommFun4BL',
        clscommfun4blv2: 'js/PubFun/clsCommFun4BLV2',
        clscommonfunc4web: 'js/PubFun/clsCommonFunc4Web',
        clsgeneraltab: 'js/PubFun/clsGeneralTab',
        clssyspara4webapi: 'js/PubFun/clsSysPara4WebApi',
        cachehelper: 'js/PubFun/CacheHelper',
        clsstacktrace: 'js/PubFun/clsStackTrace',
        clscboobject: 'js/PubFun/clscboobject',
        clscommsession: 'js/PubFun/clsCommSession',

        jspubfun: 'js/PubFun/jsPubFun',
        clsfldcomparisonobj: 'js/PubFun/clsFldComparisonObj',
        wapicollege_qudi_ts: 'js/Pages/BaseInfo/WApiCollege_QUDI_TS.js'
    },
    //waitSeconds: 15,
    waitSeconds: 0,//”¿‘∂≤ª≥¨ ±
    shim: {
        'bootstrap': {
            deps: ["jquery", "popper"]
        }        
    },
    map: {
        '*': {
            'popper.js': 'popper'
        }
    }
});

//requirejs(['app'], function (app) {
//    console.log('app in config.js')
//    console.log(app);
//});
