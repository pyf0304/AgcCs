/*-- -- -- -- -- -- -- -- -- -- --
类名:clsGitIgnoreParser
功能:.gitignore 文件解析器
生成日期:2026/06/10
生成者:Copilot
工程名称:AGC
模块中文名:资源管理
模块英文名:ResourceMan
== == == == == == == == == == == == 
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using com.taishsoft.common;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// .gitignore 文件解析器
    /// </summary>
    public class clsGitIgnoreParser
    {
        private List<GitIgnoreRule> _rules = new List<GitIgnoreRule>();
        private string _baseDirectory;

        /// <summary>
        /// .gitignore 规则
        /// </summary>
        private class GitIgnoreRule
        {
            public string Pattern { get; set; }
            public bool IsNegation { get; set; }
            public bool IsDirectory { get; set; }
            public Regex Regex { get; set; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="gitIgnoreFilePath">.gitignore 文件路径</param>
        /// <param name="baseDirectory">基础目录（通常是项目根目录）</param>
        public clsGitIgnoreParser(string gitIgnoreFilePath, string baseDirectory)
        {
            _baseDirectory = NormalizePath(baseDirectory);

            if (File.Exists(gitIgnoreFilePath))
            {
                ParseGitIgnoreFile(gitIgnoreFilePath);
            }
        }

        /// <summary>
        /// 解析 .gitignore 文件
        /// </summary>
        private void ParseGitIgnoreFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();

                    // 跳过空行和注释
                    if (string.IsNullOrEmpty(trimmedLine) || trimmedLine.StartsWith("#"))
                    {
                        continue;
                    }

                    GitIgnoreRule rule = new GitIgnoreRule();
                    string pattern = trimmedLine;

                    // 检查是否是否定规则（以 ! 开头）
                    if (pattern.StartsWith("!"))
                    {
                        rule.IsNegation = true;
                        pattern = pattern.Substring(1);
                    }

                    // 检查是否是目录规则（以 / 结尾）
                    if (pattern.EndsWith("/"))
                    {
                        rule.IsDirectory = true;
                        pattern = pattern.TrimEnd('/');
                    }

                    rule.Pattern = pattern;
                    rule.Regex = ConvertGitPatternToRegex(pattern);
                    _rules.Add(rule);
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("解析 .gitignore 文件出错：{0} (in {1})",
                    ex.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg, ex);
            }
        }

        /// <summary>
        /// 将 Git 模式转换为正则表达式
        /// </summary>
        private Regex ConvertGitPatternToRegex(string pattern)
        {
            string regexPattern = "^";
            bool hasSlash = pattern.Contains("/");

            // 如果模式以 / 开头，表示从根目录匹配
            if (pattern.StartsWith("/"))
            {
                pattern = pattern.Substring(1);
                regexPattern += Regex.Escape(_baseDirectory).Replace("\\\\", "[\\\\/]") + "[\\\\/]";
            }
            else if (!hasSlash)
            {
                // 如果没有 /，可以匹配任何目录
                regexPattern = "";
            }

            for (int i = 0; i < pattern.Length; i++)
            {
                char c = pattern[i];

                if (c == '*')
                {
                    if (i + 1 < pattern.Length && pattern[i + 1] == '*')
                    {
                        // ** 匹配任意层级目录
                        regexPattern += ".*";
                        i++; // 跳过下一个 *
                    }
                    else
                    {
                        // * 匹配除 / 外的任意字符
                        regexPattern += "[^\\\\/]*";
                    }
                }
                else if (c == '?')
                {
                    // ? 匹配单个字符（除 / 外）
                    regexPattern += "[^\\\\/]";
                }
                else if (c == '/')
                {
                    // / 匹配路径分隔符
                    regexPattern += "[\\\\/]";
                }
                else
                {
                    // 转义特殊字符
                    regexPattern += Regex.Escape(c.ToString());
                }
            }

            // 如果是目录模式或包含 **，匹配整个路径
            if (pattern.Contains("**") || pattern.EndsWith("/"))
            {
                regexPattern += "($|[\\\\/])";
            }
            else
            {
                regexPattern += "$";
            }

            return new Regex(regexPattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 检查文件或目录是否应该被忽略
        /// </summary>
        /// <param name="path">文件或目录的完整路径</param>
        /// <param name="isDirectory">是否是目录</param>
        /// <returns>true 表示应该忽略，false 表示不应该忽略</returns>
        public bool ShouldIgnore(string path, bool isDirectory = false)
        {
            if (string.IsNullOrEmpty(path))
            {
                return false;
            }

            string normalizedPath = NormalizePath(path);
            string relativePath = GetRelativePath(_baseDirectory, normalizedPath);

            bool isIgnored = false;

            foreach (GitIgnoreRule rule in _rules)
            {
                bool matches = false;

                // 检查规则是否匹配
                if (rule.IsDirectory && !isDirectory)
                {
                    // 目录规则只匹配目录
                    continue;
                }

                // 尝试匹配完整路径
                matches = rule.Regex.IsMatch(normalizedPath);

                // 如果没有 /，也尝试匹配文件名
                if (!matches && !rule.Pattern.Contains("/"))
                {
                    string fileName = Path.GetFileName(normalizedPath);
                    matches = rule.Regex.IsMatch(fileName);
                }

                // 如果没有 /，也检查相对路径中的任何部分
                if (!matches && !rule.Pattern.Contains("/"))
                {
                    string[] pathParts = relativePath.Split(new[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string part in pathParts)
                    {
                        if (rule.Regex.IsMatch(part))
                        {
                            matches = true;
                            break;
                        }
                    }
                }

                if (matches)
                {
                    if (rule.IsNegation)
                    {
                        // 否定规则，取消忽略
                        isIgnored = false;
                    }
                    else
                    {
                        // 正常规则，标记为忽略
                        isIgnored = true;
                    }
                }
            }

            return isIgnored;
        }

        /// <summary>
        /// 标准化路径（统一使用 / 作为分隔符）
        /// </summary>
        private string NormalizePath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return path;
            }
            return path.Replace("\\", "/").TrimEnd('/');
        }

        /// <summary>
        /// 获取相对路径
        /// </summary>
        private string GetRelativePath(string basePath, string fullPath)
        {
            basePath = NormalizePath(basePath);
            fullPath = NormalizePath(fullPath);

            if (fullPath.StartsWith(basePath, StringComparison.OrdinalIgnoreCase))
            {
                string relativePath = fullPath.Substring(basePath.Length).TrimStart('/');
                return relativePath;
            }

            return fullPath;
        }

        /// <summary>
        /// 从项目根目录加载 .gitignore 文件
        /// </summary>
        /// <param name="projectDirectory">项目根目录</param>
        /// <returns>解析器实例，如果文件不存在返回空解析器</returns>
        public static clsGitIgnoreParser LoadFromDirectory(string projectDirectory)
        {
            string gitIgnorePath = Path.Combine(projectDirectory, ".gitignore");
            return new clsGitIgnoreParser(gitIgnorePath, projectDirectory);
        }
    }
}