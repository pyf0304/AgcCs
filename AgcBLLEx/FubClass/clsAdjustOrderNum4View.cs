using AGC.BusinessLogic;
using AGC.Entity;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGC.BusinessLogicEx
{
    public class clsAdjustOrderNum4View
    {
        public List<string> ClassificationFieldValueLst { get; set; }
        public string OrderNumFieldName { get; set; }
        public string FieldLst { get; set; }
        public string VarDefLst { get; set; }

        public string VarLst { get; set; }
        public clsFeatureRegionFldsENEx objFeatureRegionFlds_AdjustOrderNum = null;
        //public clsTabFeatureFldsENEx objField_OrderNum = null;
        public IEnumerable<clsViewFeatureFldsENEx> arrvViewFeatureFlds_Classify = null;
        public static clsAdjustOrderNum4View GetOrderNumInfoByViewInfo(clsViewInfoENEx objViewInfoENEx)
        {
            clsAdjustOrderNum4View objAdjustOrderNum = new clsAdjustOrderNum4View();

            objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.AdjustOrderNum_1196);
            if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return null;
            //clsViewFeatureFldsENEx objField_OrderNum = objViewInfoENEx.arrViewFeatureFlds.Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);
            objAdjustOrderNum.arrvViewFeatureFlds_Classify = objViewInfoENEx.arrViewFeatureFlds
                .Where(x => x.FieldTypeId == enumFieldType.ClassificationField_10 
                        && x.ViewFeatureId == objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum.ViewFeatureId)
                        .OrderBy(x=>x.OrderNum);

            if (string.IsNullOrEmpty(objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum.ReleFldId))
            {
                throw new Exception(string.Format("//表：[{0}]的序号字段为空,不能生成调整次序相关函数;", objViewInfoENEx.TabName));
       
            }
          
            objAdjustOrderNum.OrderNumFieldName = objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum.ObjFieldTabENEx.FldName;

            List<string> arrVar = null;
              
            if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
            {
            
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Any(x=>x.CtrlId.Length<4))
                {
                    string strMsg = string.Format("分类字段的控件Id(CtrlId)不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                List<string> arrFldName = objAdjustOrderNum.arrvViewFeatureFlds_Classify
                    .Select(x => x.CtrlId.Substring(3))
                    .ToList();
                objAdjustOrderNum.ClassificationFieldValueLst = arrFldName;
                objAdjustOrderNum.FieldLst = string.Join(",", arrFldName.ToArray());

                List<string> arrVarDef = objAdjustOrderNum.arrvViewFeatureFlds_Classify
                    .Select(x => string.Format("{0} {1}", x.CsType, x.CtrlId.Substring(3)))
                    .ToList();
                objAdjustOrderNum.VarDefLst = string.Join(",", arrVarDef.ToArray());

                arrVar = objAdjustOrderNum.arrvViewFeatureFlds_Classify
                    .Select(x => string.Format("{0}", x.CtrlId.Substring(3)))
                    .ToList();
                objAdjustOrderNum.VarLst = string.Join(",", arrVar.ToArray());
            }

            return objAdjustOrderNum;
        }

        public static clsAdjustOrderNum4View GetOrderNumInfoByViewInfo2(string strViewId, string strPrjId,  List<clsFeatureRegionFldsENEx> arrFeatureRegionFlds, List<clsViewFeatureFldsENEx> arrViewFeatureFlds)
        {
            clsAdjustOrderNum4View objAdjustOrderNum = new clsAdjustOrderNum4View();

            objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum = arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.AdjustOrderNum_1196);
            if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return null;
            //clsViewFeatureFldsENEx objField_OrderNum = objViewInfoENEx.arrViewFeatureFlds.Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);
            objAdjustOrderNum.arrvViewFeatureFlds_Classify = arrViewFeatureFlds
                .Where(x => x.FieldTypeId == enumFieldType.ClassificationField_10
                        && x.ViewFeatureId == objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum.ViewFeatureId)
                        .OrderBy(x => x.OrderNum);

            if (string.IsNullOrEmpty(objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum.ReleFldId))
            {
                string strTabName = clsViewInfoBLEx.GetMainTabName(strViewId, strPrjId);
                throw new Exception(string.Format("//表：[{0}]的序号字段为空,不能生成调整次序相关函数;", strTabName));

            }

            objAdjustOrderNum.OrderNumFieldName = objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum.ObjFieldTabENEx.FldName;

            List<string> arrVar = null;

            if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
            {

                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Any(x => x.CtrlId.Length < 4))
                {
                    string strMsg = string.Format("分类字段的控件Id(CtrlId)不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                List<string> arrFldName = objAdjustOrderNum.arrvViewFeatureFlds_Classify
                    .Select(x => x.CtrlId.Substring(3))
                    .ToList();
                objAdjustOrderNum.ClassificationFieldValueLst = arrFldName;
                objAdjustOrderNum.FieldLst = string.Join(",", arrFldName.ToArray());

                List<string> arrVarDef = objAdjustOrderNum.arrvViewFeatureFlds_Classify
                    .Select(x => string.Format("{0} {1}", x.CsType, x.CtrlId.Substring(3)))
                    .ToList();
                objAdjustOrderNum.VarDefLst = string.Join(",", arrVarDef.ToArray());

                arrVar = objAdjustOrderNum.arrvViewFeatureFlds_Classify
                    .Select(x => string.Format("{0}", x.CtrlId.Substring(3)))
                    .ToList();
                objAdjustOrderNum.VarLst = string.Join(",", arrVar.ToArray());
            }

            return objAdjustOrderNum;
        }


        public static clsAdjustOrderNum4View GetOrderNumInfoByViewId(string strViewId, string strPrjId)
        {
            List<string> arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdAndRegionTypeId(strViewId, enumRegionType.FeatureRegion_0008);
            if (arrRegionId.Count == 0) return null;

            List<clsFeatureRegionFldsENEx> arrFeatureRegionFlds = clsFeatureRegionFldsBLEx.GetObjExLstByRegionId(arrRegionId[0]);

            List<clsViewFeatureFldsENEx> arrViewFeatureFlds = clsViewFeatureFldsBLEx.GetObjExLstByRegionId(arrRegionId[0], strPrjId);
            arrViewFeatureFlds = arrViewFeatureFlds.Where(x=>x.ReleFldId.Count()>0).ToList();
            clsAdjustOrderNum4View objAdjustOrderNum = new clsAdjustOrderNum4View();

            objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum = arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.AdjustOrderNum_1196);
            if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return null;
            //clsViewFeatureFldsENEx objField_OrderNum = objViewInfoENEx.arrViewFeatureFlds.Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);
            objAdjustOrderNum.arrvViewFeatureFlds_Classify = arrViewFeatureFlds
                .Where(x => x.FieldTypeId == enumFieldType.ClassificationField_10
                        && x.ViewFeatureId == objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum.ViewFeatureId)
                        .OrderBy(x => x.OrderNum);

            if (string.IsNullOrEmpty(objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum.ReleFldId))
            {
                string strTabName = clsViewInfoBLEx.GetMainTabName(strViewId, strPrjId);
                throw new Exception(string.Format("//表：[{0}]的序号字段为空,不能生成调整次序相关函数;", strTabName));

            }

            objAdjustOrderNum.OrderNumFieldName = clsFieldTabBL.GetNameByFldIdCache( objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum.ReleFldId, strPrjId);

            List<string> arrVar = null;

            if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
            {

                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Any(x => x.CtrlId.Length < 4))
                {
                    string strMsg = string.Format("分类字段的控件Id(CtrlId)不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                List<string> arrFldName = objAdjustOrderNum.arrvViewFeatureFlds_Classify
                    .Select(x => x.CtrlId.Substring(3))
                    .ToList();
                objAdjustOrderNum.ClassificationFieldValueLst = arrFldName;
                objAdjustOrderNum.FieldLst = string.Join(",", arrFldName.ToArray());

                List<string> arrVarDef = objAdjustOrderNum.arrvViewFeatureFlds_Classify
                    .Select(x => string.Format("{0} {1}", x.CsType, x.CtrlId.Substring(3)))
                    .ToList();
                objAdjustOrderNum.VarDefLst = string.Join(",", arrVarDef.ToArray());

                arrVar = objAdjustOrderNum.arrvViewFeatureFlds_Classify
                    .Select(x => string.Format("{0}", x.CtrlId.Substring(3)))
                    .ToList();
                objAdjustOrderNum.VarLst = string.Join(",", arrVar.ToArray());
            }

            return objAdjustOrderNum;
        }

    }

}
