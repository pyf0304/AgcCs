using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsASPButtonENEx : clsASPButtonEN
    {
        public clsFeatureRegionFldsENEx objFeatureRegionFldsENEx = null;
        public clsASPButtonENEx() : base()
        {
            this.CssClass = "Button_Defa";
        }

    }
}
