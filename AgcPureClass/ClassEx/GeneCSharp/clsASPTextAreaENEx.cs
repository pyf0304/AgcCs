using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.PureClass
{
    public class ASPTextAreaEx : ASPTextArea
    {
        public ASPTextAreaEx()
        {
            this.ControlType = "ASPTextAreaEx";
        }
        /// <summary>
        /// 文本模式
        /// </summary>
        public string TextMode { get; set; }
    }
}
