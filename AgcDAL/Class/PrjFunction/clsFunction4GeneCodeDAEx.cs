using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.DAL
{
    public class clsFunction4GeneCodeDAEx : clsFunction4GeneCodeDA
    {
        public bool GoTop(List<string> lstKey, string strCodeTypeId, string strProgLangTypeId)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder sbCondition = new StringBuilder();
       
            sbCondition.AppendFormat(" {0} = '{1}'", conFunction4GeneCode.FuncCodeTypeId, strCodeTypeId);
            sbCondition.AppendFormat(" And {0} = '{1}'", conFunction4GeneCode.ProgLangTypeId, strProgLangTypeId);

            sbCondition.AppendFormat(" And {0} in ({1})", conFunction4GeneCode.FuncId4GC, strKeyList);
            List<clsFunction4GeneCodeEN> arrFunction4GeneCodeLst = GetObjLst(sbCondition.ToString());
            foreach (clsFunction4GeneCodeEN objFunction4GeneCode in arrFunction4GeneCodeLst)
            {
                objFunction4GeneCode.OrderNum = objFunction4GeneCode.OrderNum - 10000;
                UpdateBySql2(objFunction4GeneCode);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey, string strCodeTypeId, string strProgLangTypeId)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" {0} = '{1}'", conFunction4GeneCode.FuncCodeTypeId, strCodeTypeId);
            sbCondition.AppendFormat(" And {0} = '{1}'", conFunction4GeneCode.ProgLangTypeId, strProgLangTypeId);

            sbCondition.AppendFormat(" And {0} in ({1})", conFunction4GeneCode.FuncId4GC, strKeyList);
            List<clsFunction4GeneCodeEN> arrFunction4GeneCodeLst = GetObjLst(sbCondition.ToString());
            foreach (clsFunction4GeneCodeEN objFunction4GeneCode in arrFunction4GeneCodeLst)
            {

                objFunction4GeneCode.OrderNum = objFunction4GeneCode.OrderNum + 10000;

                UpdateBySql2(objFunction4GeneCode);
            }
            return true;
        }
        public bool ReOrder(string strCodeTypeId, string strProgLangTypeId)
        {
            string strCondition = string.Format("{0} = '{1}' And {2}='{3}' order by OrderNum ",    
              conFunction4GeneCode.ProgLangTypeId, strProgLangTypeId,
              conFunction4GeneCode.FuncCodeTypeId, strCodeTypeId);
            List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjList
                = new clsFunction4GeneCodeDA().GetObjLst(strCondition);
            int intIndex = 1;
            foreach (clsFunction4GeneCodeEN objFunction4GeneCode in arrFunction4GeneCodeObjList)
            {
                objFunction4GeneCode.OrderNum = intIndex;
                //objFunction4GeneCode.FuncId4GC
                this.UpdateBySql2(objFunction4GeneCode);
                intIndex++;
            }
            return true;
        }
        public bool AdjustSequenceNumber(string strDirect, string strCurrKey)
        {
            //操作步骤：
            //1、获取当前所选中的关键字FuncId4GC。
            //2、根据关键字FuncId4GC来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字FuncId4GC
            //5、把当前关键字FuncId4GC的序号加(减)1
            //6、把下一个序号的关键字FuncId4GC减(加)1
            //7、重新显示DATAGRID
            ///

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			string strCurrKey;
            string strPrevKey = "";	//上一条序号的关键字FuncId4GC
            string strNextKey = "";	//下一条序号的关键字FuncId4GC
            int intTabRecNum;		//当前表中字段的记录数
      
            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsFunction4GeneCodeEN objFunction4GeneCode = GetObjByFuncId4GC(strCurrKey);

            intOrderNum = objFunction4GeneCode.OrderNum;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
         
            string strCurrProgLangTypeId = objFunction4GeneCode.ProgLangTypeId;     //获取当前记录的{表ID}
            string strCurrCodeTypeId = objFunction4GeneCode.FuncCodeTypeId;		//获取当前记录的{表ID}
            strCondition = new StringBuilder();       
            strCondition.AppendFormat(" {0} = '{1}'", conFunction4GeneCode.FuncCodeTypeId, strCurrCodeTypeId);
            strCondition.AppendFormat(" And {0} = '{1}'", conFunction4GeneCode.ProgLangTypeId, strCurrProgLangTypeId);
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("Function4GeneCode", strCondition.ToString());	//获取当前{表ID}的记录数
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

            //4、获取下(上)一个序号字段的关键字FuncId4GC
            if (strDirect == "UP")
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat(" {0} = '{1}'", conFunction4GeneCode.FuncCodeTypeId, strCurrCodeTypeId);
                strCondition.AppendFormat(" And {0} = '{1}'", conFunction4GeneCode.ProgLangTypeId, strCurrProgLangTypeId);
                strCondition.AppendFormat(" And {0} = {1}", conFunction4GeneCode.OrderNum, intOrderNum - 1);

                //strCondition.AppendFormat("FuncId4GC = '{0}' and OrderNum = {1}",
                //    strCurrFuncId4GC, intOrderNum - 1);
                strPrevKey = this.GetFirstID(strCondition.ToString());

                if (string.IsNullOrEmpty(strPrevKey) == true)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat(" {0} = '{1}'", conFunction4GeneCode.FuncCodeTypeId, strCurrCodeTypeId);
                strCondition.AppendFormat(" And {0} = '{1}'", conFunction4GeneCode.ProgLangTypeId, strCurrProgLangTypeId);
                strCondition.AppendFormat(" And {0} = {1}", conFunction4GeneCode.OrderNum, intOrderNum + 1);

                //strCondition.AppendFormat("FuncId4GC = '{0}' and OrderNum = {1}",
                //    strCurrFuncId4GC, intOrderNum + 1);
                strNextKey = this.GetFirstID(strCondition.ToString());
                if (string.IsNullOrEmpty(strNextKey) == true)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            //5、把当前关键字FuncId4GC的序号加(减)1
            //6、把下一个序号的关键字FuncId4GC减(加)1
            if (strDirect == "UP")
            {
                clsGeneralTab2.funSetFldValue("Function4GeneCode", "OrderNum", intOrderNum - 1, string.Format("{0} = '{1}'", conFunction4GeneCode.FuncId4GC, strCurrKey));
                clsGeneralTab2.funSetFldValue("Function4GeneCode", "OrderNum", intPrevOrderNum + 1, string.Format("{0} = '{1}'", conFunction4GeneCode.FuncId4GC, strPrevKey));
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("Function4GeneCode", "OrderNum", intOrderNum + 1, string.Format("{0} = '{1}'", conFunction4GeneCode.FuncId4GC, strCurrKey));
                clsGeneralTab2.funSetFldValue("Function4GeneCode", "OrderNum", intNextOrderNum - 1, string.Format("{0} = '{1}'", conFunction4GeneCode.FuncId4GC, strNextKey));
            }
            //7、重新显示DATAGRID
            return true;
        }

    }
}
