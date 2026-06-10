// 在 Gen_Share_method_DeleteKeyIdCache() 方法中
// 将单个字段参数改为 Key 对象参数

// 生成 Key 类型名称
string strKeyTypeName = $"{TabName_In4Edit}Key";

// 替换参数定义
// 原来: export function PrjDataBase_DeleteKeyIdCache(strPrjDataBaseId: string): void
// 改为: export function PrjDataBase_DeleteKeyIdCache(key: PrjDataBaseKey): void

if (PrjTabEx_EditRegion.IsHasCacheClassifyFldTS() == false)
{
    strCodeForCs.AppendFormat("\r\n" + "export function {0}DeleteKeyIdCache(key: {1}): void", 
        this.tabNameHead, strKeyTypeName);
    strFuncName = $"{this.tabNameHead}DeleteKeyIdCache";
}

// 修改检查空值的逻辑
foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
{
    string strPrivateVarName = objInFor.ObjFieldTab().PrivFuncName();
    string strPropertyName = clsString.FirstLcaseS(objInFor.FldName);

    sbCheckEmpty.Append("\r\n" + clsPubFun4GC.Gc_CheckVarEmpty_Ts(
        $"key.{strPropertyName}",  // 使用 key.prjDataBaseId 而不是 strPrjDataBaseId
        objInFor.TypeScriptType,
        objInFor.DataTypeId,
        this.ClsName, 
        strFuncName_Temp,
        objInFor.FldLength,
        objInFor.DataTypeId == enumDataTypeAbbr.char_04, 
        this, 
        this.strBaseUrl));
}

// 修改 getCacheKey() 调用
strCodeForCs.Append("\r\n" + "// 使用 delete 删除特定的键");
strCodeForCs.Append("\r\n" + getCacheKeyFromKeyObject());  // 新方法
strCodeForCs.Append("\r\n" + $"delete {clsString.FstLcaseS(TabName_Out4ListRegion)}Cache[cacheKey];");