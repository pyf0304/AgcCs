


using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
namespace CodeStruct
{
    public class CodeAnalyzer
    {
        // 自定义排序优先级（数值越小，优先级越高）
        public static Dictionary<CodeElementType, int> sortPriority = new Dictionary<CodeElementType, int>
{

    { CodeElementType.Namespace, 0 },    // 域名
    { CodeElementType.Import, 1 },    // 域名
    { CodeElementType.Interface, 2 },

    { CodeElementType.Delegate, 3 },    // 明确表示委托类型
    { CodeElementType.EventHandler, 4 },    // 表示事件处理器
    { CodeElementType.StaticVar, 5 },    // 常量排最前
    { CodeElementType.Constant, 6 },    // 常量排最前
    { CodeElementType.RefConstant, 7 },    // 常量排最前
    { CodeElementType.ReactiveConstant, 8 },    // 常量排最前
    
    { CodeElementType.Struct,9 },       // 字段

    { CodeElementType.Field, 10 },       // 字段
    { CodeElementType.Property, 11 },
    { CodeElementType.Constructor, 12 }, // 构造函数
    
    { CodeElementType.OnMounted, 20 },      // 方法
    { CodeElementType.WatchEffect, 21 },      // 方法
    
    { CodeElementType.Method, 22 },      // 方法
    // 其他类型按需补充    
    { CodeElementType.Class, 23 },
    { CodeElementType.Template, 31 },
    { CodeElementType.Script, 32 },
    { CodeElementType.Style, 33 },
    { CodeElementType.Table, 34 },
    { CodeElementType.TrHead, 35 },
{ CodeElementType.TrRow, 36 },
{ CodeElementType.Tr, 37 },

    { CodeElementType.Components, 40 },
    { CodeElementType.Props, 41 },
    { CodeElementType.Emits, 42 },
    { CodeElementType.Setup, 43 },
    { CodeElementType.Methods, 44 },
    { CodeElementType.Watch, 45 },
     { CodeElementType.SetupReturn, 46 },
    

       
                
    // 默认值（未列出的类型排在最后）
};
        public CodeElement AnalyzeFile(string filePath)
        {
            var code = File.ReadAllText(filePath);
            var tree = CSharpSyntaxTree.ParseText(code);
            var root = tree.GetCompilationUnitRoot();

            var result = new CodeElement
            {
                ElementType = CodeElementType.Namespace,
                Name = "Global",
                Children = new System.Collections.Generic.List<CodeElement>()
            };

            foreach (var member in root.Members)
            {
                if (member is NamespaceDeclarationSyntax ns)
                    result.Children.Add(ParseNamespace(ns));
                else if (member is BaseTypeDeclarationSyntax btd)
                    result.Children.Add(ParseType(btd));
            }

            return result;
        }

        private CodeElement ParseNamespace(NamespaceDeclarationSyntax ns)
        {
            var node = new CodeElement
            {
                ElementType = CodeElementType.Namespace,
                Name = ns.Name.ToString(),
            };

            foreach (var member in ns.Members)
            {
                if (member is BaseTypeDeclarationSyntax btd)
                    node.Children.Add(ParseType(btd));
            }

            return node;
        }

        private CodeElement ParseType(BaseTypeDeclarationSyntax typeDecl)
        {
            //CodeElementType type = typeDecl switch
            //{
            //    ClassDeclarationSyntax => CodeElementType.Class,
            //    StructDeclarationSyntax => CodeElementType.Struct,
            //    InterfaceDeclarationSyntax => CodeElementType.Interface,
            //    EnumDeclarationSyntax => CodeElementType.Enum,
            //    _ => throw new NotImplementedException()
            //};

            CodeElementType type;

            if (typeDecl is ClassDeclarationSyntax)
                type = CodeElementType.Class;
            else if (typeDecl is StructDeclarationSyntax)
                type = CodeElementType.Struct;
            else if (typeDecl is InterfaceDeclarationSyntax)
                type = CodeElementType.Interface;
            else if (typeDecl is EnumDeclarationSyntax)
                type = CodeElementType.Enum;
            else
                throw new NotImplementedException();

            var result = new CodeElement
            {
                ElementType = type,
                Name = typeDecl.Identifier.Text,
                Children = new System.Collections.Generic.List<CodeElement>()
            };

            if (typeDecl is ClassDeclarationSyntax cls)
            {
                foreach (var member in cls.Members)
                    result.Children.Add(ParseMember(member));
            }

            return result;
        }

        private CodeElement ParseMember(MemberDeclarationSyntax member)
        {
            switch (member)
            {
                case MethodDeclarationSyntax method:
                    return new CodeElement
                    {
                        ElementType = CodeElementType.Method,
                        Name = method.Identifier.Text,
                        ReturnType = method.ReturnType.ToString(),
                        Modifiers = string.Join(" ", method.Modifiers),
                        Parameters = method.ParameterList.Parameters
                            .Select(p => (p.Identifier.Text, p.Type?.ToString() ?? "var"))
                            .ToList()
                    };

                case FieldDeclarationSyntax field:
                    var isConst = field.Modifiers.Any(m => m.IsKind(SyntaxKind.ConstKeyword));
                    return new CodeElement
                    {
                        ElementType = isConst ? CodeElementType.Constant : CodeElementType.Field,
                        Name = field.Declaration.Variables.First().Identifier.Text,
                        ReturnType = field.Declaration.Type.ToString(),
                        Modifiers = string.Join(" ", field.Modifiers)
                    };

                case PropertyDeclarationSyntax prop:
                    return new CodeElement
                    {
                        ElementType = CodeElementType.Property,
                        Name = prop.Identifier.Text,
                        ReturnType = prop.Type.ToString(),
                        Modifiers = string.Join(" ", prop.Modifiers)
                    };

                case ConstructorDeclarationSyntax ctor:
                    return new CodeElement
                    {
                        ElementType = CodeElementType.Constructor,
                        Name = ctor.Identifier.Text,
                        ReturnType = "",
                        Modifiers = string.Join(" ", ctor.Modifiers),
                        Parameters = ctor.ParameterList.Parameters
                            .Select(p => (p.Identifier.Text, p.Type?.ToString() ?? "var"))
                            .ToList()
                    };

                default:
                    return new CodeElement
                    {
                        ElementType = CodeElementType.Field,
                        Name = "Unknown",
                        ReturnType = "",
                        Modifiers = ""
                    };
            }
        }

        public void PrintTree(CodeElement element, string indent = "")
        {
            Console.WriteLine($"{indent}- {element.ElementType}: {element.Name} ({element.ReturnType})");
            foreach (var child in element.Children)
            {
                PrintTree(child, indent + "  ");
            }
        }

        public void ExportToJson(CodeElement element, string outputPath)
        {
            var json = JsonSerializer.Serialize(element, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            System.IO.File.WriteAllText(outputPath, json);
        }
        public static void SortCodeElements(List<CodeElement> elements, Dictionary<CodeElementType, int> priority)
        {
            if (elements == null) return;

            // 排序当前层级
            var sorted = elements
                .OrderBy(e => priority.TryGetValue(e.ElementType, out int p) ? p : int.MaxValue)
                .ThenBy(e => e.Name)
                .ToList();

            elements.Clear();
            elements.AddRange(sorted);

            // 递归排序子元素
            foreach (var child in elements)
            {
                SortCodeElements(child.Children, priority);
            }
        }
        public static CodeElement FindElementByName(CodeElement root, string name)
        {
            if (root.Name == name)
                return root;

            foreach (var child in root.Children)
            {
                var found = FindElementByName(child, name);
                if (found != null)
                    return found;
            }

            return null;
        }
    }

}
