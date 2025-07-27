using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCommBase
{
    public class SortInfo
    {
        public string SortField { get; set; }
        public string SortDirection { get; set; }
        public List<string> JoinTables { get; set; } = new List<string>();
        public List<string> JoinConditions { get; set; } = new List<string>();
        public string FormatType { get; set; } // "Old" or "New"
    }




    public class clsSortLinkStrParse
    {
        public clsSortLinkStrParse() { }

        //    string sortStr1 = "GCVariable|varName Asc|GCVariablePrjIdRela.VarId = GCVariable.VarId";
        //        string sortStr2 = "dataTypeName Asc|(GCDefaConstants)GCConstantPrjIdRela.ConstId = GCDefaConstants.ConstId|(DataTypeAbbr)GCDefaConstants.DataTypeId = DataTypeAbbr.DataTypeId";

        //        var info1 = ParseSortString(sortStr1);
        //        var info2 = ParseSortString(sortStr2);

        //Console.WriteLine($"格式: {info1.FormatType}, 排序字段: {info1.SortField}, 方向: {info1.SortDirection}");
        //Console.WriteLine($"连接表: {string.Join(",", info1.JoinTables)}");
        //Console.WriteLine($"连接条件: {string.Join(" | ", info1.JoinConditions)}");

        //Console.WriteLine("---");

        //Console.WriteLine($"格式: {info2.FormatType}, 排序字段: {info2.SortField}, 方向: {info2.SortDirection}");
        //Console.WriteLine($"连接表: {string.Join(",", info2.JoinTables)}");
        //Console.WriteLine($"连接条件: {string.Join(" | ", info2.JoinConditions)}");
        public static SortInfo ParseSortString(string strSortBy)
        {
            var parts = strSortBy.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
            var result = new SortInfo();

            if (parts.Length == 0)
                return result;

            // 老格式：JoinTable | SortField SortDirection | JoinCondition
            if (!parts[0].Contains(" ") && (parts[1].Contains(" Asc") || parts[1].Contains(" Desc")))
            {
                result.FormatType = "Old";

                result.JoinTables.Add(parts[0]);

                var sortParts = parts[1].Trim().Split(' ');
                result.SortField = sortParts[0];
                result.SortDirection = sortParts.Length > 1 ? sortParts[1] : "Asc";

                for (int i = 2; i < parts.Length; i++)
                {
                    result.JoinConditions.Add(parts[i]);
                }
            }
            // 新格式：SortField SortDirection | JoinCondition | JoinCondition...
            else
            {
                result.FormatType = "New";

                var sortParts = parts[0].Trim().Split(' ');
                result.SortField = sortParts[0];
                result.SortDirection = sortParts.Length > 1 ? sortParts[1] : "Asc";

                for (int i = 1; i < parts.Length; i++)
                {
                    string condition = parts[i].Trim();

                    // 尝试提取连接表名 (括号包围的前缀)
                    var match = System.Text.RegularExpressions.Regex.Match(condition, @"^\((.*?)\)");
                    if (match.Success)
                    {
                        result.JoinTables.Add(match.Groups[1].Value);
                        condition = condition.Substring(match.Value.Length); // 去掉表名部分
                    }

                    result.JoinConditions.Add(condition);
                }
            }

            return result;
        }

        public static string BuildLeftJoinClause(List<string> joinTables, List<string> joinConditions)
        {
            //            var joinTables = new List<string> { "GCDefaConstants", "DataTypeAbbr" };
            //            var joinConditions = new List<string>
            //{
            //    "GCConstantPrjIdRela.ConstId = GCDefaConstants.ConstId",
            //    "GCDefaConstants.DataTypeId = DataTypeAbbr.DataTypeId"
            //};

            //            string sqlJoin = BuildLeftJoinClause(joinTables, joinConditions);

            //            Console.WriteLine(sqlJoin);
            //            LEFT JOIN GCDefaConstants ON GCConstantPrjIdRela.ConstId = GCDefaConstants.ConstId
            //LEFT JOIN DataTypeAbbr ON GCDefaConstants.DataTypeId = DataTypeAbbr.DataTypeId


            if (joinTables == null || joinConditions == null || joinConditions.Count == 0)
                return string.Empty;

            var result = new List<string>();

            // 用字典记录每个连接表对应的连接条件
            var tableConditionMap = new Dictionary<string, List<string>>();


            // 按照 joinTables 的顺序来生成 JOIN 子句
            for (int i = 0; i < joinTables.Count; i++)
            {
                var table = joinTables[i];
                var conditions = joinConditions[i];
                //if (tableConditionMap.TryGetValue(table, out var conditions))
                //{
                //    string onClause = string.Join(" AND ", conditions);
                result.Add($" LEFT JOIN {table} ON {conditions} ");
                //}
            }

            return string.Join("\r\n", result);
        }

        public static string BuildLeftJoinClause2(List<string> joinTables, List<string> joinConditions)
        {
            //            var joinTables = new List<string> { "GCDefaConstants", "DataTypeAbbr" };
            //            var joinConditions = new List<string>
            //{
            //    "GCConstantPrjIdRela.ConstId = GCDefaConstants.ConstId",
            //    "GCDefaConstants.DataTypeId = DataTypeAbbr.DataTypeId"
            //};

            //            string sqlJoin = BuildLeftJoinClause(joinTables, joinConditions);

            //            Console.WriteLine(sqlJoin);
//            LEFT JOIN GCDefaConstants ON GCConstantPrjIdRela.ConstId = GCDefaConstants.ConstId
//LEFT JOIN DataTypeAbbr ON GCDefaConstants.DataTypeId = DataTypeAbbr.DataTypeId


            if (joinTables == null || joinConditions == null || joinConditions.Count == 0)
                return string.Empty;

            var result = new List<string>();

            // 用字典记录每个连接表对应的连接条件
            var tableConditionMap = new Dictionary<string, List<string>>();

            foreach (var condition in joinConditions)
            {
                string table = joinTables.FirstOrDefault(t => condition.Contains(t + "."));
                if (!string.IsNullOrEmpty(table))
                {
                    if (!tableConditionMap.ContainsKey(table))
                        tableConditionMap[table] = new List<string>();
                    tableConditionMap[table].Add(condition);
                }
            }

            // 按照 joinTables 的顺序来生成 JOIN 子句
            foreach (var table in joinTables)
            {
                if (tableConditionMap.TryGetValue(table, out var conditions))
                {
                    string onClause = string.Join(" AND ", conditions);
                    result.Add($"LEFT JOIN {table} ON {onClause}");
                }
            }

            return string.Join(" ", result);
        }


        public static (string SortField, string SortDirection, List<string> JoinTables, List<string> JoinConditions) ParseSortBy(string strSortBy)
        {
            //var strSortBy = "csType Desc|(GCDefaConstants)GCConstantPrjIdRela.ConstId = GCDefaConstants.ConstId|(DataTypeAbbr)GCDefaConstants.DataTypeId = DataTypeAbbr.DataTypeId|";
            //var result = ParseSortBy(strSortBy);

            //Console.WriteLine("排序字段: " + result.SortField);
            //Console.WriteLine("排序方向: " + result.SortDirection);
            //Console.WriteLine("连接表: " + string.Join(", ", result.JoinTables));
            //Console.WriteLine("连接条件: " + string.Join(" | ", result.JoinConditions));
            // 去除首尾空格和多余的分隔符
            strSortBy = strSortBy?.Trim('|', ' ', '\t', '\r', '\n');
            var parts = strSortBy.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            string sortField = null;
            string sortDirection = null;
            var joinTables = new List<string>();
            var joinConditions = new List<string>();

            if (parts.Length > 0)
            {
                // 解析排序部分
                var sortPart = parts[0].Trim();
                var sortTokens = sortPart.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (sortTokens.Length >= 2)
                {
                    sortField = sortTokens[0].Trim();
                    sortDirection = sortTokens[1].Trim();
                }
                else if (sortTokens.Length == 1)
                {
                    sortField = sortTokens[0].Trim();
                    sortDirection = "Asc"; // 默认升序
                }
            }

            // 解析连接表和连接条件
            for (int i = 1; i < parts.Length; i++)
            {
                var part = parts[i].Trim();
                // 形如 (TableName)条件
                if (part.StartsWith("("))
                {
                    int idx = part.IndexOf(')');
                    if (idx > 0)
                    {
                        string table = part.Substring(1, idx - 1).Trim();
                        string condition = part.Substring(idx + 1).Trim();
                        if (!string.IsNullOrEmpty(table)) joinTables.Add(table);
                        if (!string.IsNullOrEmpty(condition)) joinConditions.Add(condition);
                    }
                }
            }

            return (sortField, sortDirection, joinTables, joinConditions);
        }
    }
}
