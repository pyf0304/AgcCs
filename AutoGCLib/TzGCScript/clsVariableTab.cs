using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoGCLib.TzGCScript
{
    /// <summary>
    /// 变量表
    /// </summary>
    public class clsVariableTab
    {
        public static List<clsVariable> arrVariableLst = new List<clsVariable>();
        /// <summary>
        /// 添加变量
        /// </summary>
        /// <param name="strVariableName">变量名</param>
        /// <param name="objVariableValue">变量值</param>
        /// <returns></returns>
        public static bool AddVariable(string strVariableName, object objVariableValue)
        {
            clsVariable objVariable = GetVariableObj(strVariableName);
            if (objVariable == null)
            {
                objVariable = new clsVariable();
                objVariable.VariableName = strVariableName;
                objVariable.VariableValue = objVariableValue;
                arrVariableLst.Add(objVariable);
            }
            objVariable.VariableValue = objVariableValue;
            return true;
        }
        /// <summary>
        /// 根据变量名获取变量对象
        /// </summary>
        /// <param name="strVariableName">变量名</param>
        /// <returns></returns>
        public static clsVariable GetVariableObj(string strVariableName)
        {
            foreach (clsVariable objVariable in arrVariableLst)
            {
                if (objVariable.VariableName == strVariableName)
                {
                    return objVariable;
                }
            }
            return null;
        }
        /// <summary>
        /// 根据变量名删除变量对象
        /// </summary>
        /// <param name="strVariableName">变量名</param>
        /// <returns></returns>
        public static bool DelVariableObj(string strVariableName)
        {
            foreach (clsVariable objVariable in arrVariableLst)
            {
                if (objVariable.VariableName == strVariableName)
                {
                    return arrVariableLst.Remove( objVariable);
                }
            }
            return false;
        }

    }
}
