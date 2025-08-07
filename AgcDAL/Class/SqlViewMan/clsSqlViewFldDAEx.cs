using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.DAL
{
    public class clsSqlViewFldDAEx : clsSqlViewFldDA
    {
        public bool AdjustSequenceNumber(string strDirect, long lngmId)
        {
            ///操作步骤：
            //1、获取当前所选中的关键字mId。
            ///2、根据关键字mId来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字mId
            //5、把当前关键字mId的序号加(减)1
            //6、把下一个序号的关键字mId减(加)1
                       

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			long lngmId;
            long lngPrevmId = 0;	//上一条序号的关键字mId
            long lngNextmId = 0;	//下一条序号的关键字mId
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrSqlViewId;

            //ArrayList arrID;
            StringBuilder sbCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsSqlViewFldEN objSqlViewFld = GetObjBymId(lngmId);

            intOrderNum = objSqlViewFld.OrderNum;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            strCurrSqlViewId = objSqlViewFld.SqlViewId;		//获取当前记录的{表ID}

            string strCondition4Class = string.Format("SqlViewId='{0}'", strCurrSqlViewId);
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("SqlViewFld", strCondition4Class);	//获取当前{表ID}的记录数
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

            //4、获取下(上)一个序号字段的关键字mId
            if (strDirect == "UP")
            {
                sbCondition.AppendFormat("SqlViewId='{0}'  and OrderNum = {1}",
                     strCurrSqlViewId, intOrderNum - 1);
                lngPrevmId = this.GetFirstID(sbCondition.ToString());

                if (lngPrevmId == 0)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                sbCondition.AppendFormat("SqlViewId='{0}' and OrderNum = {1}",
                     strCurrSqlViewId, intOrderNum + 1);
                lngNextmId = this.GetFirstID(sbCondition.ToString());

                if (lngNextmId == 0)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            //5、把当前关键字mId的序号加(减)1
            //6、把下一个序号的关键字mId减(加)1
            if (strDirect == "UP")
            {
                clsGeneralTab2.funSetFldValue("SqlViewFld", "OrderNum", intOrderNum - 1, "mId = " + lngmId);
                clsGeneralTab2.funSetFldValue("SqlViewFld", "OrderNum", intPrevOrderNum + 1, "mId = " + lngPrevmId);
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("SqlViewFld", "OrderNum", intOrderNum + 1, "mId = " + lngmId);
                clsGeneralTab2.funSetFldValue("SqlViewFld", "OrderNum", intNextOrderNum - 1, "mId = " + lngNextmId);
            }
            
            return true;
        }
        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" mId in ({0})", strKeyList);
            List<clsSqlViewFldEN> arrSqlViewFldLst = GetObjLst(sbCondition.ToString());
            foreach (clsSqlViewFldEN objSqlViewFld in arrSqlViewFldLst)
            {

                objSqlViewFld.OrderNum = objSqlViewFld.OrderNum - 10000;

                UpdateBySql2(objSqlViewFld);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" mId in ({0})", strKeyList);
            List<clsSqlViewFldEN> arrSqlViewFldLst = GetObjLst(sbCondition.ToString());
            foreach (clsSqlViewFldEN objSqlViewFld in arrSqlViewFldLst)
            {

                objSqlViewFld.OrderNum = objSqlViewFld.OrderNum + 10000;

                UpdateBySql2(objSqlViewFld);
            }
            return true;
        }

        public bool ReOrder(string strSqlViewId)
        {
            string strCondition4Class = string.Format("SqlViewId='{0}' order by OrderNum ",
               strSqlViewId);

            List<clsSqlViewFldEN> arrSqlViewFldObjList = new clsSqlViewFldDA().GetObjLst(strCondition4Class);
            int intIndex = 1;
            foreach (clsSqlViewFldEN objSqlViewFld in arrSqlViewFldObjList)
            {
                objSqlViewFld.OrderNum = intIndex;
                //objSqlViewFld.id_SenateGaugeVersion
                this.UpdateBySql2(objSqlViewFld);
                intIndex++;
            }
            return true;
        }

    }
}
