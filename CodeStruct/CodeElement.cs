using System;
using System.Collections.Generic;
using System.Text;

namespace CodeStruct
{
    public enum CodeElementType
    {
        Root,
        Namespace,
        Class,
        Interface,
        Struct,
        Enum,
        Method,
        Delegate,    // 新增：明确表示委托类型
        EventHandler,  // 新增：表示事件处理器
        Field,
        Property,
        StaticVar,//静态变量
        Constant,
        RefConstant,//引用型常量，vue文件中使用
        ReactiveConstant, //引用型常量，vue文件中使用
        Constructor,
        Import,
        Template,
            Script,
        Style,
        Table,
        Tr,
        TrHead,
        TrRow,
        Methods,
        Setup,
        Props,
        Emits,
        Watch,
        SetupReturn,
        WatchEffect, 
        Components,
        OnMounted
    }
   
    public class CodeElement
    {
        public CodeElementType ElementType { get; set; }
        public string Name { get; set; }
        public string ReturnType { get; set; }
        public string Modifiers { get; set; }
        public List<(string Name, string Type)> Parameters { get; set; } = new List<(string Name, string Type)>();
        public List<CodeElement> Children { get; set; } = new List<CodeElement>();
        // ✅ 新增：原始代码片段
        public string CodeContent { get; set; }

        // 可选：注释内容
        public string DocumentationComment { get; set; }
        public string From { get; set; }

        // 可选：节点所在行号
        public int? StartLine { get; set; }
        public int? EndLine { get; set; }

        public bool isExported { get; set; }
        public bool isAbstract { get; set; }
        public bool isPublic { get; set; }
        public bool isAsync { get; set; }
        public bool isStatic { get; set; }
        public bool isOverride { get; set; }
        public bool isVirtual { get; set; }
        public List<string> implements = new List<string>();
        public string RefFuncName { get; set; } // 引用的函数名
    }
    public static class CodeElementExtensions
    {
        public static CodeElement With(this CodeElement element, Action<CodeElement> update)
        {
            update(element);
            return element;
        }
    }
}
