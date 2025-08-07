using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgcCommBase
{
    internal class enumFuncParaType
    {
    }

    public enum enumTsValueGivingMode
    {
        /// <summary>
        /// 缺省值
        /// </summary>
        DefaultValue_01,
        /// <summary>
        /// 给定值
        /// </summary>
        GivenValue_02,
    }
    public enum enumAppLevel
    {
        DefindFunc,
        InvokeFunc,
    }
    public enum tsVarType
    {
        tsCache,
        tsStatic,
        tsCondition,
        tsDefaultValue,
        tsSession,
        tsGivingValue,
        tsOther,
    }
    /// <summary>
    /// 变量功能
    /// </summary>
    public enum tsVarFunction
    {
        tsCache,
        tsCondition,
    }
}
