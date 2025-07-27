using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGCLib
{
    public class clsAdjustOrderNum
    {
        public string ClassificationFieldValue { get; set; }
        public string OrderNumFieldName { get; set; }
        public string FieldLst { get; set; }
        public List<string> VarDefLst { get; set; }

        public string VarLst { get; set; }
        public clsTabFeatureEN objTabFeature_AdjustOrderNum = null;
        public clsPrjTabFldEN objPrjTabFldEN_OrderNum = null;
        public clsTabFeatureFldsEN objField_OrderNum = null;
        public IEnumerable<clsTabFeatureFldsEN> arrFieldLst_Classify = null;
        public static clsAdjustOrderNum GetOrderNumInfoByPrjTab(clsPrjTabENEx objPrjTabENEx)
        {
            clsAdjustOrderNum objAdjustOrderNum = new clsAdjustOrderNum();
            objAdjustOrderNum.objTabFeature_AdjustOrderNum = objPrjTabENEx.arrTabFeatureSet().Find(x => x.FeatureId == enumPrjFeature.Tab_AdjustOrderNum_0167);
            
            if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return null;
            objAdjustOrderNum.objField_OrderNum = objAdjustOrderNum.objTabFeature_AdjustOrderNum.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09);
            objAdjustOrderNum.objPrjTabFldEN_OrderNum = objPrjTabENEx.arrFldSetAll.Find(x => x.FldId == objAdjustOrderNum.objField_OrderNum.FldId);

            objAdjustOrderNum.arrFieldLst_Classify = objAdjustOrderNum.objTabFeature_AdjustOrderNum.arrTabFeatureFldsSet().Where(x => x.FieldTypeId == enumFieldType.ClassificationField_10).OrderBy(x=>x.OrderNum);
            
            if (objAdjustOrderNum.objField_OrderNum == null)
            {
                throw new Exception(string.Format("\r\n" + "//表：[{0}]的序号字段为空,不能生成调整次序相关函数;", objPrjTabENEx.TabName));
            }
            objAdjustOrderNum.OrderNumFieldName = objAdjustOrderNum.objField_OrderNum.FldName();
                           
            List<string> arrVar = null;
       
            if (objAdjustOrderNum.arrFieldLst_Classify.Count() > 0)
            {
                List<string> arrFldName = objAdjustOrderNum.arrFieldLst_Classify.Select(clsTabFeatureFldsBLEx.FldName).ToList();
                objAdjustOrderNum.FieldLst = string.Join(",", arrFldName.ToArray());

                List<string> arrVarDef = objAdjustOrderNum.arrFieldLst_Classify.Select(x => string.Format("{0} {1}", x.CsType(), x.PrivFuncName())).ToList();
                objAdjustOrderNum.VarDefLst = arrVarDef;// string.Join(",", arrVarDef.ToArray());

                arrVar = objAdjustOrderNum.arrFieldLst_Classify.Select(x => string.Format("{0}", x.PrivFuncName())).ToList();
                objAdjustOrderNum.VarLst = string.Join(",", arrVar.ToArray());
            }

            return objAdjustOrderNum;
        }
    }
}
