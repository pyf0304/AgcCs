using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.DAL
{
    public class clsFunctionTemplateRelaDAEx : clsFunctionTemplateRelaDA
    {
        public bool GoTop(List<long> lstKey, string strFunctionTemplateId, string strCodeTypeId)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey.Select(x=>x.ToString()), true);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}'", conFunctionTemplateRela.FunctionTemplateId, strFunctionTemplateId);
            sbCondition.AppendFormat(" And {0} = '{1}'", conFunctionTemplateRela.CodeTypeId, strCodeTypeId);
            
            sbCondition.AppendFormat(" And Mid in ({0})", strKeyList);
            List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaLst = GetObjLst(sbCondition.ToString());
            foreach (clsFunctionTemplateRelaEN objFunctionTemplateRela in arrFunctionTemplateRelaLst)
            {
                objFunctionTemplateRela.OrderNum = objFunctionTemplateRela.OrderNum - 10000;
                UpdateBySql2(objFunctionTemplateRela);
            }
            return true;
        }
        public bool GoBottom(List<long> lstKey, string strFunctionTemplateId, string strCodeTypeId)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey.Select(x=>x.ToString()), false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}'", conFunctionTemplateRela.FunctionTemplateId, strFunctionTemplateId);
            sbCondition.AppendFormat(" And {0} = '{1}'", conFunctionTemplateRela.CodeTypeId, strCodeTypeId);
            
            sbCondition.AppendFormat(" And Mid in ({0})",                strKeyList);
            List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaLst = GetObjLst(sbCondition.ToString());
            foreach (clsFunctionTemplateRelaEN objFunctionTemplateRela in arrFunctionTemplateRelaLst)
            {

                objFunctionTemplateRela.OrderNum = objFunctionTemplateRela.OrderNum + 10000;

                UpdateBySql2(objFunctionTemplateRela);
            }
            return true;
        }
        public bool ReOrder(string strFunctionTemplateId, string strCodeTypeId)
        {
            string strCondition = string.Format("{0} = '{1}' And {2}='{3}' order by OrderNum ",
              conFunctionTemplateRela.FunctionTemplateId,  strFunctionTemplateId,              
              conFunctionTemplateRela.CodeTypeId, strCodeTypeId);
            List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjList
                = new clsFunctionTemplateRelaDA().GetObjLst(strCondition);
            int intIndex = 1;
            foreach (clsFunctionTemplateRelaEN objFunctionTemplateRela in arrFunctionTemplateRelaObjList)
            {
                objFunctionTemplateRela.OrderNum = intIndex;
                //objFunctionTemplateRela.FunctionTemplateId
                this.UpdateBySql2(objFunctionTemplateRela);
                intIndex++;
            }
            return true;
        }
        public bool AdjustSequenceNumber(string strDirect, long lngMid)
        {
            //操作步骤：
            //1、获取当前所选中的关键字FunctionTemplateId。
            //2、根据关键字FunctionTemplateId来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字FunctionTemplateId
            //5、把当前关键字FunctionTemplateId的序号加(减)1
            //6、把下一个序号的关键字FunctionTemplateId减(加)1
            //7、重新显示DATAGRID
            ///

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			string lngMid;
            long lngPrevMid = 0;	//上一条序号的关键字FunctionTemplateId
            long lngNextMid = 0;	//下一条序号的关键字FunctionTemplateId
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrFunctionTemplateId;
            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsFunctionTemplateRelaEN objFunctionTemplateRela = GetObjBymId(lngMid);

            intOrderNum = objFunctionTemplateRela.OrderNum;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            strCurrFunctionTemplateId = objFunctionTemplateRela.FunctionTemplateId;     //获取当前记录的{表ID}
            string strCurrProgLevelTypeId = objFunctionTemplateRela.CodeTypeId;		//获取当前记录的{表ID}
            strCondition = new StringBuilder();
            strCondition.AppendFormat("{0} = '{1}'", conFunctionTemplateRela.FunctionTemplateId, strCurrFunctionTemplateId);
            strCondition.AppendFormat(" And {0} = '{1}'", conFunctionTemplateRela.CodeTypeId, strCurrProgLevelTypeId);

            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("FunctionTemplateRela", strCondition.ToString());	//获取当前{表ID}的记录数
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

            //4、获取下(上)一个序号字段的关键字FunctionTemplateId
            if (strDirect == "UP")
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat("{0} = '{1}'", conFunctionTemplateRela.FunctionTemplateId, strCurrFunctionTemplateId);
                strCondition.AppendFormat(" And {0} = '{1}'", conFunctionTemplateRela.CodeTypeId, strCurrProgLevelTypeId);
                strCondition.AppendFormat(" And {0} = {1}", conFunctionTemplateRela.OrderNum, intOrderNum - 1);

                //strCondition.AppendFormat("FunctionTemplateId = '{0}' and OrderNum = {1}",
                //    strCurrFunctionTemplateId, intOrderNum - 1);
                lngPrevMid = this.GetFirstID(strCondition.ToString());

                if (lngPrevMid == 0)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat("{0} = '{1}'", conFunctionTemplateRela.FunctionTemplateId, strCurrFunctionTemplateId);
                strCondition.AppendFormat(" And {0} = '{1}'", conFunctionTemplateRela.CodeTypeId, strCurrProgLevelTypeId);
                strCondition.AppendFormat(" And {0} = {1}", conFunctionTemplateRela.OrderNum, intOrderNum + 1);

                //strCondition.AppendFormat("FunctionTemplateId = '{0}' and OrderNum = {1}",
                //    strCurrFunctionTemplateId, intOrderNum + 1);
                lngNextMid = this.GetFirstID(strCondition.ToString());
                if (lngNextMid == 0)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            //5、把当前关键字FunctionTemplateId的序号加(减)1
            //6、把下一个序号的关键字FunctionTemplateId减(加)1
            if (strDirect == "UP")
            {
                clsGeneralTab2.funSetFldValue("FunctionTemplateRela", "OrderNum", intOrderNum - 1, "mId = " + lngMid);
                clsGeneralTab2.funSetFldValue("FunctionTemplateRela", "OrderNum", intPrevOrderNum + 1, "mId = " + lngPrevMid);
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("FunctionTemplateRela", "OrderNum", intOrderNum + 1, "mId = " + lngMid);
                clsGeneralTab2.funSetFldValue("FunctionTemplateRela", "OrderNum", intNextOrderNum - 1, "mId = " + lngNextMid);
            }
            //7、重新显示DATAGRID
            return true;
        }

    }
}
