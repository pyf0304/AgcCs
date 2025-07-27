using AGC.Entity;

using com.taishsoft.commdb;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.DAL;

namespace AGC.DAL
{
    public class clsViewTypeCodeTabDAEx : clsViewTypeCodeTabDA
    {
        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(string.Format(" {0} in ({1})", conViewTypeCodeTab.ViewTypeCode, strKeyList));
            List<clsViewTypeCodeTabEN> arrViewTypeCodeTabLst = GetObjLst(sbCondition.ToString());
            foreach (clsViewTypeCodeTabEN objViewTypeCodeTab in arrViewTypeCodeTabLst)
            {

                objViewTypeCodeTab.OrderNum = objViewTypeCodeTab.OrderNum - 10000;

                UpdateBySql2(objViewTypeCodeTab);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" ViewTypeCodeTabId in ({0})", strKeyList);
            List<clsViewTypeCodeTabEN> arrViewTypeCodeTabLst = GetObjLst(sbCondition.ToString());
            foreach (clsViewTypeCodeTabEN objViewTypeCodeTab in arrViewTypeCodeTabLst)
            {

                objViewTypeCodeTab.OrderNum = objViewTypeCodeTab.OrderNum + 10000;

                UpdateBySql2(objViewTypeCodeTab);
            }
            return true;
        }
        public bool ReOrder()
        {
            List<clsViewTypeCodeTabEN> arrViewTypeCodeTabObjList = new clsViewTypeCodeTabDA().GetObjLst(" 1=1 order by OrderNum ");
            int intIndex = 1;
            foreach (clsViewTypeCodeTabEN objViewTypeCodeTab in arrViewTypeCodeTabObjList)
            {
                objViewTypeCodeTab.OrderNum = intIndex;
                this.UpdateBySql2(objViewTypeCodeTab);
                intIndex++;
            }
            return true;
        }
        public bool AdjustSequenceNumber(string strDirect, int intViewTypeCode)
        {
            //操作步骤：
            //1、获取当前所选中的关键字ViewTypeCodeTabId。
            //2、根据关键字ViewTypeCodeTabId来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字ViewTypeCodeTabId
            //5、把当前关键字ViewTypeCodeTabId的序号加(减)1
            //6、把下一个序号的关键字ViewTypeCodeTabId减(加)1
            //7、重新显示DATAGRID
            ///

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			string intViewTypeCode;
            int intPrevViewTypeCode = 0;	//上一条序号的关键字ViewTypeCodeTabId
            int intNextViewTypeCode = 0;	//下一条序号的关键字ViewTypeCodeTabId
            int intTabRecNum;       //当前表中字段的记录数

            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsViewTypeCodeTabEN objViewTypeCodeTab = GetObjByViewTypeCode(intViewTypeCode);

            intOrderNum = objViewTypeCodeTab.OrderNum??0;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，

            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("ViewTypeCodeTab", " 1=1 ");	//获取当前{表ID}的记录数
            if (strDirect == "UP")
            {
                if (intOrderNum <= 1)
                {
                    throw new Exception("已经是第一条记录，不能再上移!");
                }
            }
            else if (strDirect == "DOWN")
            {
                if (intOrderNum >= intTabRecNum)	//如果当前序号大于表记录数
                {
                    throw new Exception("已经是最后一条记录，不能再下移!");
                }
            }
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。

            //4、获取下(上)一个序号字段的关键字ViewTypeCodeTabId
            if (strDirect == "UP")
            {
                strCondition.AppendFormat(" 1=1 and OrderNum = {0}", intOrderNum - 1);
                intPrevViewTypeCode = this.GetFirstID(strCondition.ToString());

                if (intViewTypeCode == 0)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat(" 1=1 and OrderNum = {0}", intOrderNum + 1);
                intNextViewTypeCode = this.GetFirstID(strCondition.ToString());
                if (intNextViewTypeCode == 0)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            //5、把当前关键字ViewTypeCodeTabId的序号加(减)1
            //6、把下一个序号的关键字ViewTypeCodeTabId减(加)1
            if (strDirect == "UP")
            {
                clsGeneralTab2.funSetFldValue("ViewTypeCodeTab", "OrderNum", intOrderNum - 1, string.Format("{0} = {1}", conViewTypeCodeTab.ViewTypeCode, intViewTypeCode));
                clsGeneralTab2.funSetFldValue("ViewTypeCodeTab", "OrderNum", intPrevOrderNum + 1, string.Format("{0} = {1}", conViewTypeCodeTab.ViewTypeCode, intPrevViewTypeCode)); 
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("ViewTypeCodeTab", "OrderNum", intOrderNum + 1, string.Format("{0} = {1}", conViewTypeCodeTab.ViewTypeCode, intViewTypeCode)); 
                clsGeneralTab2.funSetFldValue("ViewTypeCodeTab", "OrderNum", intNextOrderNum - 1, string.Format("{0} = {1}", conViewTypeCodeTab.ViewTypeCode, intNextViewTypeCode)); 
            }
            //7、重新显示DATAGRID
            return true;
        }

    }
}
