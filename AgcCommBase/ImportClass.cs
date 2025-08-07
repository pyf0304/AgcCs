using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgcCommBase
{
    public class enumImportObjType
    {
        public const string WApiExtendClassFunc = "WApiExtendClassFunc";
        public const string WApiClassFunc = "WApiClassFunc";
        public const string WApiClassFuncInExWApi = "WApiClassFuncInExWApi";
        public const string ENClass = "ENClass";
        public const string ENClassInWApi = "ENClassInWApi";
        public const string BLClass = "BLClass";
        public const string BLClassFunc = "BLClassFunc";
        public const string ENExClass = "ENExClass";
        public const string CustomFunc = "CustomFunc";
        public const string StoreModule = "StoreModule";

    }
    public interface IImportClass
    {
        ImportClass AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath);
    }
    public class ImportClass
    {
        public string ClsName { get; set; }
        public bool IsDefaultCls { get; set; }

        public string FilePath { get; set; }
        public string ModuleName { get; set; }
        public string RefFuncName { get; set; } // 引用的函数名
        public static string GetOutString(string strClassName, bool bolIs4RJ)
        {
            if (bolIs4RJ == false) return strClassName;
            return string.Format("{0}_js_1.{0}", strClassName);
        }
    }
}
