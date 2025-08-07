using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.PureClass
{
    public class ASPTextBoxEx : ASPTextBox
    {
        public ASPTextBoxEx()
        {
            this.ControlType = "ASPTextBoxEx";
        }
        /// <summary>
        /// 文本模式
        /// </summary>
        public string TextMode { get; set; }
    }
}
