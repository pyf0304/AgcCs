using AGC.Entity;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.DAL
{
    public class clsPrjFeatureDAEx : clsPrjFeatureDA
    {
        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" {0} in ({1})", conPrjFeature.FeatureId, strKeyList);
            List<clsPrjFeatureEN> arrPrjFeatureLst = GetObjLst(sbCondition.ToString());
            foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureLst)
            {
                objPrjFeature.OrderNum = objPrjFeature.OrderNum - 10000;
                //objPrjFeature.FeatureId
                UpdateBySql2(objPrjFeature);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" {0} in ({1})", conPrjFeature.FeatureId, strKeyList);
            List<clsPrjFeatureEN> arrPrjFeatureLst = GetObjLst(sbCondition.ToString());
            foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureLst)
            {

                objPrjFeature.OrderNum = objPrjFeature.OrderNum + 10000;

                UpdateBySql2(objPrjFeature);
            }
            return true;
        }
        public bool ReOrder()
        {
            string strCondition = string.Format("1 = 1 order by {0} ", conPrjFeature.OrderNum);
            List<clsPrjFeatureEN> arrPrjFeatureObjList = new clsPrjFeatureDA().GetObjLst(strCondition);
            int intIndex = 1;
            foreach (clsPrjFeatureEN objPrjFeature in arrPrjFeatureObjList)
            {
                objPrjFeature.OrderNum = intIndex;
                //objPrjFeature.id_PubClassCasePrjFeatureVersion
                //objPrjFeature.FeatureId
                this.UpdateBySql2(objPrjFeature);
                intIndex++;
            }
            return true;
        }
        public bool AdjustSequenceNumber(string strDirect, string strFeatureId)
        {
            ///操作步骤：
            //1、获取当前所选中的关键字FeatureId。
            ///2、根据关键字FeatureId来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字FeatureId
            //5、把当前关键字FeatureId的序号加(减)1
            //6、把下一个序号的关键字FeatureId减(加)1
                   

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			string strFeatureId;
            string strPrevFeatureId = "";	//上一条序号的关键字FeatureId
            string strNextFeatureId = "";	//下一条序号的关键字FeatureId
            int intTabRecNum;		//当前表中字段的记录数
            //string strCurrid_PubClassCasePrjFeatureVersion;
            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsPrjFeatureEN objPrjFeature =GetObjByFeatureId(strFeatureId);

            intOrderNum = objPrjFeature.OrderNum;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //strCurrid_PubClassCasePrjFeatureVersion = objPrjFeature.id_PubClassCasePrjFeatureVersion;		//获取当前记录的{表ID}
            intTabRecNum = clsPrjFeatureDA.GetRecCountByCond(clsPrjFeatureEN._CurrTabName, "1 = 1");	//获取当前{表ID}的记录数
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

            //4、获取下(上)一个序号字段的关键字FeatureId
            if (strDirect == "UP")
            {
                strCondition.AppendFormat(" {0} = {1}", conPrjFeature.OrderNum, intOrderNum - 1);
                strPrevFeatureId = this.GetFirstID(strCondition.ToString());

                if (strPrevFeatureId == "")
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat(" {0} = {1}", conPrjFeature.OrderNum, intOrderNum + 1);
                strNextFeatureId = this.GetFirstID(strCondition.ToString());

                if (strNextFeatureId == "")
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            //5、把当前关键字FeatureId的序号加(减)1
            //6、把下一个序号的关键字FeatureId减(加)1
            if (strDirect == "UP")
            {
                clsPrjFeatureDA.SetFldValue(clsPrjFeatureEN._CurrTabName, conPrjFeature.OrderNum, intOrderNum - 1, string.Format("{0} = '{1}'", conPrjFeature.FeatureId, strFeatureId));
                clsPrjFeatureDA.SetFldValue(clsPrjFeatureEN._CurrTabName, conPrjFeature.OrderNum, intPrevOrderNum + 1, string.Format("{0} = '{1}'", conPrjFeature.FeatureId, strPrevFeatureId));
            }
            else if (strDirect == "DOWN")
            {
                clsPrjFeatureDA.SetFldValue(clsPrjFeatureEN._CurrTabName, conPrjFeature.OrderNum, intOrderNum + 1, string.Format("{0} = '{1}'", conPrjFeature.FeatureId, strFeatureId));
                clsPrjFeatureDA.SetFldValue(clsPrjFeatureEN._CurrTabName, conPrjFeature.OrderNum, intNextOrderNum - 1, string.Format("{0} = '{1}'", conPrjFeature.FeatureId, strNextFeatureId));
            }
         
            return true;
        }
    }
}
