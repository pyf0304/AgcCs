using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;
using AGC.DAL;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public partial class clsDataGridStyleBLEx : clsDataGridStyleBL
    {   
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strDgStyleId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsDataGridStyleENEx GetDataGridStyleEXExObjByDgStyleId(string strDgStyleId)
        {
            List<clsDataGridStyleEN> arrObjLstCache = clsDataGridStyleBL.GetObjLstCache();

            foreach (clsDataGridStyleEN objDataGridStyleEN in arrObjLstCache)
            {
                if (objDataGridStyleEN.DgStyleId  ==  strDgStyleId)
                {
                    clsDataGridStyleENEx objDataGridStyleENEx = new clsDataGridStyleENEx(objDataGridStyleEN);
                    return objDataGridStyleENEx;
                }
            }
            return null;
        }
        public static string GetDefaDGStyle()
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.Append("IsDefault = '1'");
            clsDataGridStyleEN objDataGridStyle = clsDataGridStyleBL.GetFirstObj_S(sbCondition.ToString());
            if (objDataGridStyle  ==  null)
            {
                return "";
            }
            return objDataGridStyle.DgStyleId;
        }
    }
}
