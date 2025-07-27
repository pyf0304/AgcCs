using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsWebSrvFunctionsENEx : clsWebSrvFunctionsEN
    {
        public List<clsWebSrvFuncParaEN> arrWebSrvFuncParaObjLst = null;			//界面相关详细表字段集合

        public clsFieldTypeEN objFieldTypeEN = null;
        public clsPrimaryTypeEN objPrimaryTypeEN = null;
        
        public clsWebSrvFunctionsENEx():base()
        {
        
        }

    }
}
