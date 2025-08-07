using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace AGC.BusinessLogicEx
{
    public class clsSetFieldVisibilityBLEx 
    {
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// </summary>
        public static List<clsSetFieldVisibilityEN> arrSetFieldVisibilityObjLstCacheEx = null;
        /// <summary>
        /// 用于记录缓存的记录数
        /// </summary>
        public static int intFldNumCacheEx = 0;

        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        //protected static int intFindFailCount = 0;

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "lngmId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsSetFieldVisibilityEN GetSetFieldVisibilityObjByUserIdCacheEx(string strUserId, string strViewName, string strFieldName)
        {
            string strCondition = string.Format("1 = 1 order by UserId, ViewName, FieldName");
            if (arrSetFieldVisibilityObjLstCacheEx  ==  null)
            {
                arrSetFieldVisibilityObjLstCacheEx = new clsSetFieldVisibilityDA().GetObjLst(strCondition);
                intFldNumCacheEx = arrSetFieldVisibilityObjLstCacheEx.Count;
            }
            int intStart = 0;
            int intEnd = intFldNumCacheEx - 1;
            int intMid = 0;
            clsSetFieldVisibilityEN objSetFieldVisibilityEN = null;
            while (intEnd >=  intStart)
            {
                intMid = (intStart + intEnd) / 2;
                objSetFieldVisibilityEN = arrSetFieldVisibilityObjLstCacheEx[intMid];
                if (objSetFieldVisibilityEN.UserId  ==  strUserId 
                    && objSetFieldVisibilityEN.ViewName.Equals(strViewName, StringComparison.InvariantCultureIgnoreCase)  ==  true
                    && objSetFieldVisibilityEN.FieldName.Equals(strFieldName, StringComparison.InvariantCultureIgnoreCase)  ==  true)
                {
                    //intFindFailCount = 0; 
                    return objSetFieldVisibilityEN;
                }
                else if (objSetFieldVisibilityEN.UserId.CompareTo(strUserId) > 0)
                {
                    intEnd = intMid - 1;
                }
                else if (objSetFieldVisibilityEN.UserId.CompareTo(strUserId)  ==  0 && objSetFieldVisibilityEN.ViewName.CompareTo(strViewName) > 0)
                {
                    intEnd = intMid - 1;
                }
                else if (objSetFieldVisibilityEN.UserId.CompareTo(strUserId)  ==  0
                    && objSetFieldVisibilityEN.ViewName.CompareTo(strViewName)  ==  0
                     && objSetFieldVisibilityEN.FieldName.CompareTo(strFieldName) > 0)
                {
                    intEnd = intMid - 1;
                }
                else
                {
                    intStart = intMid + 1;
                }
            }
            return null;
        }
        /// <summary>
        /// 获取字段名列表从所提供的GridView中
        /// </summary>
        /// <param name = "objGV">所提供的GridView</param>
        /// <param name = "strViewName">界面名称</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>是否成功？</returns>
        public static bool GetFldNameLstByGridView(GridView objGV, string strViewName, string strUserId)
        {
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(1);
            foreach (DataControlField objDGColumn in objGV.Columns)
            {
                string strColumnName = "";
                string strHeaderText = "";
                string strColTypeName = objDGColumn.GetType().ToString();
                if (strColTypeName.IndexOf("BoundField") >=  0)
                {
                    BoundField objBoundField = (BoundField)objDGColumn;
                    strColumnName = objBoundField.DataField;
                    strHeaderText = objBoundField.HeaderText;
                }
                else if (strColTypeName.IndexOf("CheckBoxField") >=  0)
                {
                    CheckBoxField objCheckBoxField = (CheckBoxField)objDGColumn;
                    strColumnName = objCheckBoxField.DataField;
                    strHeaderText = objCheckBoxField.HeaderText;
                }
                else
                {
                    continue;
                }
                clsSetFieldVisibilityEN objSetFieldVisibilityEN = new clsSetFieldVisibilityEN();
                objSetFieldVisibilityEN.ViewName = strViewName;
                objSetFieldVisibilityEN.UserId = strUserId;
                objSetFieldVisibilityEN.FieldName = strColumnName;
                objSetFieldVisibilityEN.Caption = strHeaderText;

                objSetFieldVisibilityEN.CtrlType = "GridView";
                objSetFieldVisibilityEN.IsVisible = objDGColumn.Visible;
                objSetFieldVisibilityEN.UpdDate = strCurrDate14;
                objSetFieldVisibilityEN.UpdUserId = strUserId;
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.AppendFormat("UserId = '{0}'", objSetFieldVisibilityEN.UserId);
                sbCondition.AppendFormat(" And ViewName = '{0}'", objSetFieldVisibilityEN.ViewName);
                sbCondition.AppendFormat(" And FieldName = '{0}'", objSetFieldVisibilityEN.FieldName);
                if (clsSetFieldVisibilityBL.IsExistRecord(sbCondition.ToString())  ==  true)
                {
                    objSetFieldVisibilityEN.UpdateWithCondition(sbCondition.ToString());
                }
                else
                {
                    clsSetFieldVisibilityBL.AddNewRecordBySql2(objSetFieldVisibilityEN);
                }
            }//foreach (DataControlField objDGColumn in objGV.Columns)
            return true;
        }


        public static void SetGvVisibilityByViewName(GridView objGV, string strViewName, string strUserId)
        {
            foreach (DataControlField objDGColumn in objGV.Columns)
            {
       
                string strColumnName = "";
                string strHeaderText = "";
                string strColTypeName = objDGColumn.GetType().ToString();
                if (strColTypeName.IndexOf("BoundField") >=  0)
                {
                    BoundField objBoundField = (BoundField)objDGColumn;
                    strColumnName = objBoundField.DataField;
                    strHeaderText = objBoundField.HeaderText;
                }
                else if (strColTypeName.IndexOf("CheckBoxField") >=  0)
                {
                    CheckBoxField objCheckBoxField = (CheckBoxField)objDGColumn;
                    strColumnName = objCheckBoxField.DataField;
                    strHeaderText = objCheckBoxField.HeaderText;
                }
                else
                {
                    continue;
                }
                       
                clsSetFieldVisibilityEN objSetFieldVisibilityEN = GetSetFieldVisibilityObjByUserIdCacheEx(strUserId, strViewName, strColumnName);
                if (objSetFieldVisibilityEN  ==  null)
                {
                    continue;
                }
                bool bolIsVisible = objSetFieldVisibilityEN.IsVisible;
                if (bolIsVisible  ==  false)
                {
                    objDGColumn.Visible = false;
                }
                else
                {
                    objDGColumn.Visible = true;
                }
                //if (strColumnName  ==  "卡号" && clsMyConfig.School  ==  "THXY")
                //{
                //    objDGColumn.HeaderText = "工号";
                //}
            }
        }

    }
}
