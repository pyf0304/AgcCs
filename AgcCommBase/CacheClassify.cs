using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgcCommBase
{


    public enum WA_F
    {
         FldId,
        GetObjFromJsonObj,
        GetObjLst_Cache,
        GetObjLst_CacheFromObjLst,
        GetSubObjLstCache,
        GetObjByKeyLstAsync,
        GetObjByKeyId,
        GetObjByKeyId_Cache,
        GetRecNameByKeyCache,
        ReFreshThisCache,
        ReFreshCache,
        GetObjLstByJSONObjLst,
        GetObjLstAsync,
        GetObjLstsessionStorage,
        GetObjLstlocalStorage,
        GetObjLstClientCache,
        GetObjLstsessionStoragePureCache,
        GetObjLstlocalStoragePureCache,
        SortFunByKey,
        SortFunByExKey,
        FuncMapByFldName,
        JoinByKeyLst,
        GetUniCondStr,
        GetUniCondStr4Update,
        _CurrTabName,
        GetRecCountByCondAsync,
        DelRecordAsync,
        DelRecKeyLstAsync,
        DelMultiRecord,
        DelMultiRecordAsync,
        DelMultiRecordByCond,
        DelMultiRecordByCondAsync,
        DelRecKeyLstsAsync,
        GetObjLstByPagerAsync,
        GetMaxStrIdAsync,
        GetMaxStrIdByPrefixAsync,
        AddNewRecordAsync,
        AddNewRecordWithMaxIdAsync,
        AddNewRecordWithReturnKeyAsync,
        EditRecordExAsync,
        UpdateRecordAsync,
        UpdateObjSave,
        GetObjLstByKeyLstAsync,//单关键字列表
        GetObjLstByKeyLstAsync_SqlTab,
        GetObjLstByKeyLstsCache,//多关键字列表，Cache
        GetObjLstByKeyLstCache,//单关键字列表，Cache
        GetObjLstByPagerCache,//分页函数，对象列表，Cache
        GetObjExLstByPagerAsync,//分页函数，扩展对象列表
        AddNewObjSave,//添加新对象到数据库中
        GetObjExLstByPagerCache,//分页函数，扩展对象列表，Cache
        GetRecCountByCondCache,
        CopyToEx,
        SortFunDefa,
        CheckPropertyNew,
        CheckProperty4Update,
        IsExistRecordAsync,
        IsExistAsync,
        GoBottomAsync,
GoTopAsync,
GoBackAsync,
GoForwardAsync,
        ReOrderAsync,
        DownMoveAsync,
        UpMoveAsync,
        CheckUniCond4Add,
        CheckUniCond4Update,
    }

    public class CacheClassify
    {
        public string FldId;
        public string FldId2;
        public string FldName;
        public string FldName2;
        public string PriVarName;
        public string PriVarName2;
        public string TypeScriptType;
        public string TypeScriptType2;
        public string CsType;
        public string CsType2;
        public string DataTypeId;
        public string DataTypeId2;
        public int FldLength;
        public int FldLength2;
        public bool IsHasCacheClassfyFld;
        public bool IsHasCacheClassfyFld2;
        public bool IsHasCacheClassfyFld_TS;
        public bool IsHasCacheClassfyFld2_TS;
        public bool IsNumberType;
        public bool IsNumberType2;
        public bool IsForExtendClass;
        public bool IsForExtendClass2;
        public string VarDef4Fld;
        public string VarDef4Fld2;
    }
    public class CacheClassify4View
    {
        public string FldId;
        public string FldId2;
        public string FldName;
        public string FldName2;
        public string ViewVarName { get; 
            set; }
        public string ViewVarName2;
        public string VarDef4Fld;
        public string VarDef4Fld2;
        public string PriVarName;
        public string PriVarName2;
        public string TypeScriptType;
        public string TypeScriptType2;
        public string DataTypeId;
        public string DataTypeId2;
        public int FldLength;
        public int FldLength2;
        public bool IsHasCacheClassfyFld;
        public bool IsHasCacheClassfyFld2;
        public bool IsNumberType;
        public bool IsNumberType2;
        public bool IsForExtendClass;
        public bool IsForExtendClass2;

    }

}
