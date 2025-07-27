using AGC.BusinessLogic;

using AGC.DAL;
using AGC.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsFieldTypeBLEx : clsFieldTypeBL
    {
        /// <summary>
        /// 获取相关对象列表, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns>获取相关对象列表</returns>
        public static List<clsFieldTypeEN> GetFieldTypeObjLstForBindDdl()
        {
            List<clsFieldTypeEN> arrFieldTypeObjLstCache = clsFieldTypeBL.GetObjLstCache();
            return arrFieldTypeObjLstCache;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strFeatureId">功能Id</param>
        public static void BindDdl_FieldTypeIdByFeatureId(System.Web.UI.WebControls.DropDownList objDDL, string strFeatureId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[字段类型表]...", "0");
            string strCondition = string.Format("{0} in (Select {0} From {1} where {2} = '{3}') Order By {4}",
                conFieldType.FieldTypeId,
                conFeatureFieldTypeRela._CurrTabName, conFeatureFieldTypeRela.FeatureId, strFeatureId,
                conFieldType.OrderNum);
            IEnumerable<clsFieldTypeEN> arrObjLst = clsFieldTypeBL.GetObjLst(strCondition);
            objDDL.DataValueField = conFieldType.FieldTypeId;
            objDDL.DataTextField = conFieldType.FieldTypeName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定基于Web的下拉框-使用Cache
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
        /// </summary>
        /// <param name = "strFeatureId">功能Id</param>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_FieldTypeIdByFeatureIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strFeatureId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[字段类型表]...", "0");
            IEnumerable<clsFieldTypeEN> arrFieldTypeObjLst = GetAllFieldTypeObjLstCache();
            IEnumerable<clsFeatureFieldTypeRelaEN> arrFeatureFieldTypeRela = clsFeatureFieldTypeRelaBL.GetAllFeatureFieldTypeRelaObjLstCache();
            IEnumerable<clsFeatureFieldTypeRelaEN> arrFeatureFieldTypeRela_Sel = arrFeatureFieldTypeRela.Where(x => x.FeatureId == strFeatureId);
            IEnumerable<string> arrFieldTypeId = arrFeatureFieldTypeRela_Sel.Select(x => x.FieldTypeId);
            IEnumerable<clsFieldTypeEN> arrFieldTypeObjLst_Sel = arrFieldTypeObjLst.Where(x => arrFieldTypeId.Contains(x.FieldTypeId));
            objDDL.DataValueField = conFieldType.FieldTypeId;
            objDDL.DataTextField = conFieldType.FieldTypeName;
            objDDL.DataSource = arrFieldTypeObjLst_Sel;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
    }
}
