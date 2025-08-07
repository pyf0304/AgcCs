using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoGCLib.TzGCScript
{
public    class clsVariable
    {
        private string mstrVariableName;
        private object mobjVariableValue;
        private string mstrApplicableScope;
        /// <summary>
        /// 变量名
        /// </summary>
        public string VariableName
        {
            get
            {
                return mstrVariableName;
            }

            set
            {
                mstrVariableName = value;
            }
        }
        /// <summary>
        /// 变量值
        /// </summary>
        public object VariableValue
        {
            get
            {
                return mobjVariableValue;
            }

            set
            {
                mobjVariableValue = value;
            }
        }
        /// <summary>
        /// 适用范围
        /// </summary>
        public string ApplicableScope
        {
            get
            {
                return mstrApplicableScope;
            }

            set
            {
                mstrApplicableScope = value;
            }
        }
    }
}
