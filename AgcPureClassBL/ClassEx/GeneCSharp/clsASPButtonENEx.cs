using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

namespace AGC.PureClass
{
    public class ASPButtonEx : ASPButton
    {
        public clsFeatureRegionFldsENEx objFeatureRegionFldsENEx = null;
        public ASPButtonEx() : base()
        {
            this.CssClass = "Button_Defa";
        }

    }
}
