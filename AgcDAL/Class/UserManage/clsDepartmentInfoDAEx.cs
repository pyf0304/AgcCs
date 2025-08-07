using AGC.Entity;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGC.DAL
{
    public class clsDepartmentInfoDAEx : clsDepartmentInfoDA
    {
        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" DepartmentId in ({0})", strKeyList);
            List<clsDepartmentInfoEN> arrDepartmentInfoLst = GetObjLst(sbCondition.ToString());
            foreach (clsDepartmentInfoEN objDepartmentInfo in arrDepartmentInfoLst)
            {

                objDepartmentInfo.OrderNum = objDepartmentInfo.OrderNum - 10000;
                //objDepartmentInfo.DepartmentId
                UpdateBySql2(objDepartmentInfo);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" DepartmentId in ({0})", strKeyList);
            List<clsDepartmentInfoEN> arrDepartmentInfoLst = GetObjLst(sbCondition.ToString());
            foreach (clsDepartmentInfoEN objDepartmentInfo in arrDepartmentInfoLst)
            {

                objDepartmentInfo.OrderNum = objDepartmentInfo.OrderNum + 10000;

                UpdateBySql2(objDepartmentInfo);
            }
            return true;
        }
        public bool ReOrder()
        {
            List<clsDepartmentInfoEN> arrDepartmentInfoObjList = new clsDepartmentInfoDA().GetObjLst("1 = 1 order by OrderNum ");
            int intIndex = 1;
            foreach (clsDepartmentInfoEN objDepartmentInfo in arrDepartmentInfoObjList)
            {
                objDepartmentInfo.OrderNum = intIndex;
                //objDepartmentInfo.id_PubClassCaseDepartmentInfoVersion
                //objDepartmentInfo.DepartmentId
                this.UpdateBySql2(objDepartmentInfo);
                intIndex++;
            }
            return true;
        }
        public bool AdjustSequenceNumber(string strDirect, string strDepartmentId)
        {
            ///操作步骤：
            //1、获取当前所选中的关键字DepartmentId。
            ///2、根据关键字DepartmentId来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字DepartmentId
            //5、把当前关键字DepartmentId的序号加(减)1
            //6、把下一个序号的关键字DepartmentId减(加)1
            
            ///

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			string strDepartmentId;
            string strPrevDepartmentId = "";	//上一条序号的关键字DepartmentId
            string strNextDepartmentId = "";	//下一条序号的关键字DepartmentId
            int intTabRecNum;		//当前表中字段的记录数
            //string strCurrid_PubClassCaseDepartmentInfoVersion;
            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsDepartmentInfoEN objDepartmentInfo = GetObjByDepartmentId(strDepartmentId);

            intOrderNum = objDepartmentInfo.OrderNum ?? 0;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //strCurrid_PubClassCaseDepartmentInfoVersion = objDepartmentInfo.id_PubClassCaseDepartmentInfoVersion;		//获取当前记录的{表ID}
            intTabRecNum = clsDepartmentInfoDA.GetRecCountByCond(clsDepartmentInfoEN._CurrTabName, "1 = 1");	//获取当前{表ID}的记录数
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

            //4、获取下(上)一个序号字段的关键字DepartmentId
            if (strDirect == "UP")
            {
                strCondition.AppendFormat(" OrderNum = {0}", intOrderNum - 1);
                strPrevDepartmentId = this.GetFirstID(strCondition.ToString());

                if (strPrevDepartmentId == "")
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat(" OrderNum = {0}", intOrderNum + 1);
                strNextDepartmentId = this.GetFirstID(strCondition.ToString());

                if (strNextDepartmentId == "")
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            //5、把当前关键字DepartmentId的序号加(减)1
            //6、把下一个序号的关键字DepartmentId减(加)1
            if (strDirect == "UP")
            {
                clsDepartmentInfoDA.SetFldValue(clsDepartmentInfoEN._CurrTabName, "OrderNum", intOrderNum - 1, "DepartmentId = " + strDepartmentId);
                clsDepartmentInfoDA.SetFldValue(clsDepartmentInfoEN._CurrTabName, "OrderNum", intPrevOrderNum + 1, "DepartmentId = " + strPrevDepartmentId);
            }
            else if (strDirect == "DOWN")
            {
                clsDepartmentInfoDA.SetFldValue(clsDepartmentInfoEN._CurrTabName, "OrderNum", intOrderNum + 1, "DepartmentId = " + strDepartmentId);
                clsDepartmentInfoDA.SetFldValue(clsDepartmentInfoEN._CurrTabName, "OrderNum", intNextOrderNum - 1, "DepartmentId = " + strNextDepartmentId);
            }
            
            return true;
        }
    }
}
