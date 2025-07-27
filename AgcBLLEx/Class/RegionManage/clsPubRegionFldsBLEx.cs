using AGC.BusinessLogic;
using AGC.Entity;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGC.BusinessLogicEx
{
   public class clsPubRegionFldsBLEx
    {
        //public static bool AddExtendClassToPrjTabFld(clsDataNodeEN objDataNode, clsViewRegionEN objViewRegion, string strDataPropertyName, string strCaption, string strDnPathId,  string strUserId)
        //{
        //    var objFieldTab_S = objDataNode.ObjFieldTab();
        //    if (objFieldTab_S == null) return false;
        //    if (objFieldTab_S.FldName == strDataPropertyName)
        //    {
        //        if (clsPrjTabFldBLEx.IsExistSameFldId(objViewRegion.TabId, objFieldTab_S.FldId))   //判断是否有相同的关键字
        //        {
        //            var lngMid = clsPrjTabFldBLEx.GetPrimaryKeyByTabIdAndFldId(objViewRegion.TabId, objFieldTab_S.FldId);
        //            var objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngMid);
        //            objPrjTabFld.IsForExtendClass = true;
        //            //objPrjTabFld.DnPathId = strDnPathId;
        //            objPrjTabFld.UpdDate = clsDateTime.getTodayDateTimeStr(1);
        //            objPrjTabFld.UpdUser = strUserId;
        //            objPrjTabFld.Update();
        //        }
        //        else
        //        {
        //            clsPrjTabFldBLEx.AddNewRec(objViewRegion.TabId, objFieldTab_S.FldId, true, strUserId, true, strDnPathId);
        //        }
        //    }
        //    else
        //    {
        //        var strFldId = clsFieldTabBLEx.AddNewRec(strDataPropertyName, strCaption, objFieldTab_S.DataTypeId,
        //            objFieldTab_S.FldLength, objFieldTab_S.FldPrecision, true, objDataNode.PrjId, strUserId);
        //        if (string.IsNullOrEmpty(strFldId) == true) return false;
        //        if (clsPrjTabFldBLEx.IsExistSameFldId(objViewRegion.TabId, strFldId))   //判断是否有相同的关键字
        //        {
        //            var lngMid = clsPrjTabFldBLEx.GetPrimaryKeyByTabIdAndFldId(objViewRegion.TabId, strFldId);
        //            var objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngMid);
        //            objPrjTabFld.IsForExtendClass = true;
        //            objPrjTabFld.DnPathId = strDnPathId;
        //            objPrjTabFld.UpdDate = clsDateTime.getTodayDateTimeStr(1);
        //            objPrjTabFld.UpdUser = strUserId;
        //            objPrjTabFld.Update();
        //        }
        //        else
        //        {
        //            clsPrjTabFldBLEx.AddNewRec(objViewRegion.TabId, strFldId, true, strUserId, true, strDnPathId);
        //        }
        //    }

        //    return true;
        //}

    }
}
