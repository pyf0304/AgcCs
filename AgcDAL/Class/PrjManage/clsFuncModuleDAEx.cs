using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.commdb;
using AGC.Entity;
using System.Collections;
using com.taishsoft.common;

namespace AGC.DAL
{
    public class clsFuncModuleDAEx : clsFuncModule_AgcDA
    {
        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" FuncModuleAgcId in ({0})", strKeyList);
            List<clsFuncModule_AgcEN> arrFuncModuleLst = GetObjLst(sbCondition.ToString());
            foreach (clsFuncModule_AgcEN objFuncModule in arrFuncModuleLst)
            {

                objFuncModule.OrderNum = objFuncModule.OrderNum - 10000;

                UpdateBySql2(objFuncModule);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" FuncModuleAgcId in ({0})", strKeyList);
            List<clsFuncModule_AgcEN> arrFuncModuleLst = GetObjLst(sbCondition.ToString());
            foreach (clsFuncModule_AgcEN objFuncModule in arrFuncModuleLst)
            {

                objFuncModule.OrderNum = objFuncModule.OrderNum + 10000;

                UpdateBySql2(objFuncModule);
            }
            return true;
        }
        public bool ReOrder(string strPrjId)
        {
            List<clsFuncModule_AgcEN> arrFuncModuleObjList = new clsFuncModule_AgcDA().GetObjLst("PrjId = '" + strPrjId + "' order by OrderNum ");
            int intIndex = 1;
            foreach (clsFuncModule_AgcEN objFuncModule in arrFuncModuleObjList)
            {
                objFuncModule.OrderNum = intIndex;
                //objFuncModule.PrjId
                this.UpdateBySql2(objFuncModule);
                intIndex++;
            }
            return true;
        }
        public bool AdjustSequenceNumber(string strDirect, string strFuncModuleId)
        {
            //操作步骤：
            //1、获取当前所选中的关键字FuncModuleAgcId。
            //2、根据关键字FuncModuleAgcId来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字FuncModuleAgcId
            //5、把当前关键字FuncModuleAgcId的序号加(减)1
            //6、把下一个序号的关键字FuncModuleAgcId减(加)1
            //7、重新显示DATAGRID
            ///

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			string strFuncModuleId;
            string strPrevFuncModuleId = "";	//上一条序号的关键字FuncModuleAgcId
            string strNextFuncModuleId = "";	//下一条序号的关键字FuncModuleAgcId
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrPrjId;
            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsFuncModule_AgcEN objFuncModule = GetObjByFuncModuleAgcId(strFuncModuleId);

            intOrderNum = objFuncModule.OrderNum;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            strCurrPrjId = objFuncModule.PrjId;		//获取当前记录的{表ID}
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("FuncModule_Agc", "PrjId = '" + strCurrPrjId + "'");	//获取当前{表ID}的记录数
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

            //4、获取下(上)一个序号字段的关键字FuncModuleAgcId
            if (strDirect == "UP")
            {
                strCondition.AppendFormat("PrjId = '{0}' and OrderNum = {1}",
                    strCurrPrjId, intOrderNum - 1);
                strPrevFuncModuleId = this.GetFirstID(strCondition.ToString());

                if (string .IsNullOrEmpty( strPrevFuncModuleId )== true)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat("PrjId = '{0}' and OrderNum = {1}",
                    strCurrPrjId, intOrderNum + 1);
                strNextFuncModuleId = this.GetFirstID(strCondition.ToString());
                if (string.IsNullOrEmpty(strNextFuncModuleId) == true)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            //5、把当前关键字FuncModuleAgcId的序号加(减)1
            //6、把下一个序号的关键字FuncModuleAgcId减(加)1
            if (strDirect == "UP")
            {
                clsGeneralTab2.funSetFldValue("FuncModule_Agc", "OrderNum", intOrderNum - 1, "FuncModuleAgcId = " + strFuncModuleId);
                clsGeneralTab2.funSetFldValue("FuncModule_Agc", "OrderNum", intPrevOrderNum + 1, "FuncModuleAgcId = " + strPrevFuncModuleId);
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("FuncModule_Agc", "OrderNum", intOrderNum + 1, "FuncModuleAgcId = " + strFuncModuleId);
                clsGeneralTab2.funSetFldValue("FuncModule_Agc", "OrderNum", intNextOrderNum - 1, "FuncModuleAgcId = " + strNextFuncModuleId);
            }
            //7、重新显示DATAGRID
            return true;
        }


        /// <summary>
        /// 获取当前表最大字符型关键字ID
        /// </summary>
        /// <returns>返回的最大关键字值ID</returns>
        public static string GetMaxStrIdEx(string strPrjId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsFuncModule_AgcDA.GetSpecSQLObj();
            string strMaxValue = objSQL.GetMaxStrId("FuncModule_Agc", "FuncModuleAgcId", 8, strPrjId);
            return strMaxValue;
        }
    }
}
