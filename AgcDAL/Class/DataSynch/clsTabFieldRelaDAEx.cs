using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.DAL
{
    public class clsTabFieldRelaDAEx : clsTabFieldRelaDA
    {
        public bool AdjustSequenceNumber(string strDirect, long lngid_FieldTabRela)
        {
            ///操作步骤：
            //1、获取当前所选中的关键字id_FieldTabRela。
            ///2、根据关键字id_FieldTabRela来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字id_FieldTabRela
            //5、把当前关键字id_FieldTabRela的序号加(减)1
            //6、把下一个序号的关键字id_FieldTabRela减(加)1
            
            ///

            int intSequenceNumber;	//当前记录的序号
            int intPrevSequenceNumber, intNextSequenceNumber;	//上下两条记录的序号
            //			long lngid_FieldTabRela;
            long lngPrevid_FieldTabRela = 0;	//上一条序号的关键字id_FieldTabRela
            long lngNextid_FieldTabRela = 0;	//下一条序号的关键字id_FieldTabRela
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrTabId;

            //ArrayList arrID;
            StringBuilder sbCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsTabFieldRelaEN objTabFieldRela = new clsTabFieldRelaEN(lngid_FieldTabRela);
            //objTabFieldRela.id_FieldTabRela
            this.GetTabFieldRela(ref objTabFieldRela);
            intSequenceNumber = objTabFieldRela.SequenceNumber ?? 0;
            intPrevSequenceNumber = intSequenceNumber - 1;
            intNextSequenceNumber = intSequenceNumber + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            strCurrTabId = objTabFieldRela.TabId;		//获取当前记录的{表ID}

            string strCondition4Class = string.Format("TabId='{0}'", strCurrTabId);
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("TabFieldRela", strCondition4Class);	//获取当前{表ID}的记录数
            if (strDirect == "UP")
            {
                if (intSequenceNumber <= 1)
                {
                    throw new Exception("已经是第一条记录，不能再上移!");
                }
            }
            else if (strDirect == "DOWN")
            {
                if (intSequenceNumber >= intTabRecNum)	//如果当前序号大于表记录数
                {
                    throw new Exception("已经是最后一条记录，不能再下移!");
                }
            }
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。

            //4、获取下(上)一个序号字段的关键字id_FieldTabRela
            if (strDirect == "UP")
            {
                sbCondition.AppendFormat("TabId='{0}'  and SequenceNumber = {1}",
                     strCurrTabId, intSequenceNumber - 1);
                lngPrevid_FieldTabRela = this.GetFirstID(sbCondition.ToString());

                if (lngPrevid_FieldTabRela == 0)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                sbCondition.AppendFormat("TabId='{0}' and SequenceNumber = {1}",
                     strCurrTabId, intSequenceNumber + 1);
                lngNextid_FieldTabRela = this.GetFirstID(sbCondition.ToString());

                if (lngNextid_FieldTabRela == 0)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            //5、把当前关键字id_FieldTabRela的序号加(减)1
            //6、把下一个序号的关键字id_FieldTabRela减(加)1
            if (strDirect == "UP")
            {
                clsGeneralTab2.funSetFldValue("TabFieldRela", "SequenceNumber", intSequenceNumber - 1, "id_FieldTabRela = " + lngid_FieldTabRela);
                clsGeneralTab2.funSetFldValue("TabFieldRela", "SequenceNumber", intPrevSequenceNumber + 1, "id_FieldTabRela = " + lngPrevid_FieldTabRela);
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("TabFieldRela", "SequenceNumber", intSequenceNumber + 1, "id_FieldTabRela = " + lngid_FieldTabRela);
                clsGeneralTab2.funSetFldValue("TabFieldRela", "SequenceNumber", intNextSequenceNumber - 1, "id_FieldTabRela = " + lngNextid_FieldTabRela);
            }
            
            return true;
        }
        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" id_FieldTabRela in ({0})", strKeyList);
            List<clsTabFieldRelaEN> arrTabFieldRelaLst = GetObjLst(sbCondition.ToString());
            foreach (clsTabFieldRelaEN objTabFieldRela in arrTabFieldRelaLst)
            {

                objTabFieldRela.SequenceNumber = objTabFieldRela.SequenceNumber - 10000;

                UpdateBySql2(objTabFieldRela);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" id_FieldTabRela in ({0})", strKeyList);
            List<clsTabFieldRelaEN> arrTabFieldRelaLst = GetObjLst(sbCondition.ToString());
            foreach (clsTabFieldRelaEN objTabFieldRela in arrTabFieldRelaLst)
            {

                objTabFieldRela.SequenceNumber = objTabFieldRela.SequenceNumber + 10000;

                UpdateBySql2(objTabFieldRela);
            }
            return true;
        }

        public bool ReOrder(string strTabId)
        {
            string strCondition4Class = string.Format("TabId='{0}' order by SequenceNumber ",
               strTabId);

            List<clsTabFieldRelaEN> arrTabFieldRelaObjList = new clsTabFieldRelaDA().GetObjLst(strCondition4Class);
            int intIndex = 1;
            foreach (clsTabFieldRelaEN objTabFieldRela in arrTabFieldRelaObjList)
            {
                objTabFieldRela.SequenceNumber = intIndex;
                //objTabFieldRela.id_SenateGaugeVersion
                this.UpdateBySql2(objTabFieldRela);
                intIndex++;
            }
            return true;
        }

    }
}
