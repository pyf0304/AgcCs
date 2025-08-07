using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsTabFieldRelaBLEx
    {
        /// <summary>
        /// 功能:建立字段、对象的关系
        /// 建立者:潘以锋,20070711
        /// </summary>
        /// <param name = "strObjId"> 对象ID</param>
        /// <param name = "strFldId">字段ID</param>
        public static void CreateTabFldRelation(clsPrjTabFldEN objPrjTabFldEN, int intIndex)
        {
            if (IsExistSameFldId(objPrjTabFldEN.TabId, objPrjTabFldEN.FldId) == true)
            {
                return;
            }
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(objPrjTabFldEN.TabId);

            clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldEN.FldId, objPrjTabEN.PrjId);
            //clsFieldTabBLEx.GetFieldTab(ref objFieldTabEN);

            clsTabFieldRelaEN objTabFieldRela = new clsTabFieldRelaEN();
            //objTabFieldRela.id_FieldTabRela = clsGeneralTab.GetMaxStrId("TabFieldRela", "id_FieldTabRela", 8, clsSysParaEN.CurrSelPrjId);
            objTabFieldRela.FldId = objPrjTabFldEN.FldId;
            objTabFieldRela.TabId = objPrjTabFldEN.TabId;
            objTabFieldRela.PrjId = objPrjTabFldEN.PrjId;
            objTabFieldRela.SqlFldName = objFieldTabEN.FldName;
            objTabFieldRela.ExcelFieldName = objFieldTabEN.FldName;
            objTabFieldRela.SequenceNumber = intIndex;
            objTabFieldRela.TransWayId = "00";

            objTabFieldRela.IsTabUnique = objPrjTabFldEN.IsTabUnique;
            objTabFieldRela.PrimaryTypeId = objPrjTabFldEN.PrimaryTypeId;

            //if (objFieldTabEN.FldName = objPrjTabEN.KeyWord)
            //{

            //  objTabFieldRela.IsTabUnique = true;
            //  //objTabFieldRela.PrimaryTypeId = objPrjTabEN.PrimaryTypeId_T;

            //}

            objTabFieldRela.FieldTypeId = objPrjTabFldEN.FieldTypeId;

            //      objTabFieldRela.
            clsTabFieldRelaBL.CheckPropertyNew(objTabFieldRela);
            clsTabFieldRelaBL.AddNewRecordBySql2(objTabFieldRela);
        }
        /// <summary>
        /// 检查在同一表中是否存在同一字段
        /// </summary>
        /// <param name = "strTabId">表ID</param>
        /// <param name = "strFldId">字段ID</param>
        /// <returns>是否存在？</returns>
        public static bool IsExistSameFldId(string strTabId, string strFldId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("TabId = '{0}' and FldId = '{1}'", strTabId, strFldId);
            return clsTabFieldRelaBL.IsExistRecord(strCondition.ToString());
        }



        public static bool GoTop(List<string> arrKeyId, string strTabId)
        {
            try
            {
                bool bolResult = new clsTabFieldRelaDAEx().GoTop(arrKeyId);
                bolResult = new clsTabFieldRelaDAEx().ReOrder(strTabId);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错!\r\n" + objException.Message);
            }
        }

        public static bool GoTop(string strKeyId, string strTabId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsTabFieldRelaDAEx().GoTop(arrKeyId);
                bolResult = new clsTabFieldRelaDAEx().ReOrder(strTabId);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错!\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(List<string> arrKeyId, string strTabId)
        {
            try
            {
                bool bolResult = new clsTabFieldRelaDAEx().GoBottom(arrKeyId);
                bolResult = new clsTabFieldRelaDAEx().ReOrder(strTabId);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错!\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(string strKeyId, string strTabId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsTabFieldRelaDAEx().GoBottom(arrKeyId);
                bolResult = new clsTabFieldRelaDAEx().ReOrder(strTabId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错!\r\n" + objException.Message);
            }
        }


        public static bool AdjustSequenceNumber(string strDirect, long lngmId)
        {
            try
            {
                bool bolResult = new clsTabFieldRelaDAEx().AdjustSequenceNumber(strDirect, lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错!\r\n" + objException.Message);
            }
        }
        public static bool ReOrder(string strTabId)
        {
            try
            {
                bool bolResult = new clsTabFieldRelaDAEx().ReOrder(strTabId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错!\r\n" + objException.Message);
            }

        }
    }
}
