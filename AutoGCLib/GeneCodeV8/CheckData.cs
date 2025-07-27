using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace AutoGCLib
{
    public abstract partial class clsGeneCodeBase4View
    {

        public bool CheckQueryField(clsQryRegionFldsENEx objQryRegionFldsEx)
        {
            var objPrjTabFld_Var = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(TabId_Out4ListRegion, objQryRegionFldsEx.ObjFieldTab().FldId, objViewInfoENEx.PrjId);
            if (objPrjTabFld_Var == null)
            {
                string strMsg = $"在列表区表：{TabName_Out4ListRegion}中不存在查询字段:{objQryRegionFldsEx.ObjFieldTab().FldName},请检查!";
                throw new Exception(strMsg);
            }
            if (objPrjTabFld_Var.IsForExtendClass == true)
            {
                string strMsg = $"在列表区表：{TabName_Out4ListRegion}中查询字段:{objQryRegionFldsEx.ObjFieldTab().FldName}是扩展字段,不适合做查询字段,请检查!";
                throw new Exception(strMsg);
            }
            return true;
        }
    }
}
