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
    public class clsCodeTypeDAEx : clsCodeTypeDA
    {
        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" CodeTypeId in ({0})", strKeyList);
            List<clsCodeTypeEN> arrCodeTypeLst = GetObjLst(sbCondition.ToString());
            foreach (clsCodeTypeEN objCodeType in arrCodeTypeLst)
            {

                objCodeType.OrderNum = objCodeType.OrderNum - 10000;

                UpdateBySql2(objCodeType);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" CodeTypeId in ({0})", strKeyList);
            List<clsCodeTypeEN> arrCodeTypeLst = GetObjLst(sbCondition.ToString());
            foreach (clsCodeTypeEN objCodeType in arrCodeTypeLst)
            {

                objCodeType.OrderNum = objCodeType.OrderNum + 10000;

                UpdateBySql2(objCodeType);
            }
            return true;
        }
        public bool ReOrder()
        {
            List<clsCodeTypeEN> arrCodeTypeObjList = new clsCodeTypeDA().GetObjLst(" 1=1 order by OrderNum ");
            int intIndex = 1;
            foreach (clsCodeTypeEN objCodeType in arrCodeTypeObjList)
            {
                objCodeType.OrderNum = intIndex;
                this.UpdateBySql2(objCodeType);
                intIndex++;
            }
            return true;
        }
        public bool AdjustSequenceNumber(string strDirect, string strCodeTypeId)
        {
            //操作步骤：
            //1、获取当前所选中的关键字CodeTypeId。
            //2、根据关键字CodeTypeId来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字CodeTypeId
            //5、把当前关键字CodeTypeId的序号加(减)1
            //6、把下一个序号的关键字CodeTypeId减(加)1
            //7、重新显示DATAGRID
            ///

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			string strCodeTypeId;
            string strPrevCodeTypeId = "";	//上一条序号的关键字CodeTypeId
            string strNextCodeTypeId = "";	//下一条序号的关键字CodeTypeId
            int intTabRecNum;       //当前表中字段的记录数

            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsCodeTypeEN objCodeType = GetObjByCodeTypeId(strCodeTypeId);

            intOrderNum = objCodeType.OrderNum ?? 0;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，

            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("CodeType", " 1=1 ");	//获取当前{表ID}的记录数
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

            //4、获取下(上)一个序号字段的关键字CodeTypeId
            if (strDirect == "UP")
            {
                strCondition.AppendFormat(" 1=1 and OrderNum = {0}", intOrderNum - 1);
                strPrevCodeTypeId = this.GetFirstID(strCondition.ToString());

                if (string.IsNullOrEmpty(strPrevCodeTypeId) == true)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat(" 1=1 and OrderNum = {0}", intOrderNum + 1);
                strNextCodeTypeId = this.GetFirstID(strCondition.ToString());
                if (string.IsNullOrEmpty(strNextCodeTypeId) == true)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            //5、把当前关键字CodeTypeId的序号加(减)1
            //6、把下一个序号的关键字CodeTypeId减(加)1
            if (strDirect == "UP")
            {
                clsGeneralTab2.funSetFldValue("CodeType", "OrderNum", intOrderNum - 1, "CodeTypeId = " + strCodeTypeId);
                clsGeneralTab2.funSetFldValue("CodeType", "OrderNum", intPrevOrderNum + 1, "CodeTypeId = " + strPrevCodeTypeId);
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("CodeType", "OrderNum", intOrderNum + 1, "CodeTypeId = " + strCodeTypeId);
                clsGeneralTab2.funSetFldValue("CodeType", "OrderNum", intNextOrderNum - 1, "CodeTypeId = " + strNextCodeTypeId);
            }
            //7、重新显示DATAGRID
            return true;
        }

    }
}
