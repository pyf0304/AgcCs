
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFunction4CodeDAEx
表名:Function4Code
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:33:08
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:数据处理扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commexception;
using com.taishsoft.commdb;

using AGC.Entity;

namespace AGC.DAL
{
    /// <summary>
    /// 函数名4Code(Function4Code)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenDALExCode)
    /// </summary>
    public class clsFunction4CodeDAEx : clsFunction4CodeDA
    {
        //以下是属性变量
        public bool GoTop(List<string> lstKey, string strFuncTypeId)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, true);
            StringBuilder strCondition = new StringBuilder();

            strCondition.AppendFormat(" 1=1 ");
            strCondition.AppendFormat(" And {0} = '{1}'", conFunction4Code.FuncTypeId, strFuncTypeId);

            strCondition.AppendFormat(" And {0} in ({1})", conFunction4Code.FuncId4Code, strKeyList);
            List<clsFunction4CodeEN> arrFunction4CodeLst = GetObjLst(strCondition.ToString());
            foreach (clsFunction4CodeEN objFunction4Code in arrFunction4CodeLst)
            {
                objFunction4Code.OrderNum = objFunction4Code.OrderNum - 10000;
                UpdateBySql2(objFunction4Code);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey, string strFuncTypeId)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat(" 1 = 1 ");
            strCondition.AppendFormat(" And {0} = '{1}'", conFunction4Code.FuncTypeId, strFuncTypeId);

            strCondition.AppendFormat(" And {0} in ({1})", conFunction4Code.FuncId4Code, strKeyList);
            List<clsFunction4CodeEN> arrFunction4CodeLst = GetObjLst(strCondition.ToString());
            foreach (clsFunction4CodeEN objFunction4Code in arrFunction4CodeLst)
            {

                objFunction4Code.OrderNum = objFunction4Code.OrderNum + 10000;

                UpdateBySql2(objFunction4Code);
            }
            return true;
        }
        public bool ReOrder(string strFuncTypeId)
        {
            string strCondition = string.Format(" 1=1 And {0}='{1}' order by OrderNum ",
                conFunction4Code.FuncTypeId, strFuncTypeId);
            List<clsFunction4CodeEN> arrFunction4CodeObjList
                = new clsFunction4CodeDA().GetObjLst(strCondition);
            int intIndex = 1;
            foreach (clsFunction4CodeEN objFunction4Code in arrFunction4CodeObjList)
            {
                objFunction4Code.OrderNum = intIndex;
                //objFunction4Code.FuncId4Code
                this.UpdateBySql2(objFunction4Code);
                intIndex++;
            }
            return true;
        }
        public bool AdjustSequenceNumber(string strDirect, string strCurrKey)
        {
            //操作步骤：
            //1、获取当前所选中的关键字FuncId4Code。
            //2、根据关键字FuncId4Code来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字FuncId4Code
            //5、把当前关键字FuncId4Code的序号加(减)1
            //6、把下一个序号的关键字FuncId4Code减(加)1
            //7、重新显示DATAGRID
            ///

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			string strCurrKey;
            string strPrevKey = "";	//上一条序号的关键字FuncId4Code
            string strNextKey = "";	//下一条序号的关键字FuncId4Code
            int intTabRecNum;       //当前表中字段的记录数

            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsFunction4CodeEN objFunction4Code = GetObjByFuncId4Code(strCurrKey);

            intOrderNum = objFunction4Code.OrderNum;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            string strCurrFuncTypeID = objFunction4Code.FuncTypeId;     //获取当前记录的{表ID}

            strCondition = new StringBuilder();
            strCondition.AppendFormat(" 1=1 ");
            strCondition.AppendFormat(" And {0} = '{1}'", conFunction4Code.FuncTypeId, strCurrFuncTypeID);

            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("Function4Code", strCondition.ToString());	//获取当前{表ID}的记录数
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

            //4、获取下(上)一个序号字段的关键字FuncId4Code
            if (strDirect == "UP")
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat(" 1=1 ");
                strCondition.AppendFormat(" And {0} = '{1}'", conFunction4Code.FuncTypeId, strCurrFuncTypeID);
                strCondition.AppendFormat(" And {0} = {1}", conFunction4Code.OrderNum, intOrderNum - 1);

                //strCondition.AppendFormat("FuncId4Code = '{0}' and OrderNum = {1}",
                //    strCurrFuncId4Code, intOrderNum - 1);
                strPrevKey = this.GetFirstID(strCondition.ToString());

                if (string.IsNullOrEmpty(strPrevKey) == true)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat(" 1=1 ");
                strCondition.AppendFormat(" And {0} = '{1}'", conFunction4Code.FuncTypeId, strCurrFuncTypeID);
                strCondition.AppendFormat(" And {0} = {1}", conFunction4Code.OrderNum, intOrderNum + 1);

                //strCondition.AppendFormat("FuncId4Code = '{0}' and OrderNum = {1}",
                //    strCurrFuncId4Code, intOrderNum + 1);
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
            //5、把当前关键字FuncId4Code的序号加(减)1
            //6、把下一个序号的关键字FuncId4Code减(加)1
            if (strDirect == "UP")
            {
                clsGeneralTab2.funSetFldValue("Function4Code", "OrderNum", intOrderNum - 1, string.Format("{0} = '{1}'", conFunction4Code.FuncId4Code, strCurrKey));
                clsGeneralTab2.funSetFldValue("Function4Code", "OrderNum", intPrevOrderNum + 1, string.Format("{0} = '{1}'", conFunction4Code.FuncId4Code, strPrevKey));
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("Function4Code", "OrderNum", intOrderNum + 1, string.Format("{0} = '{1}'", conFunction4Code.FuncId4Code, strCurrKey));
                clsGeneralTab2.funSetFldValue("Function4Code", "OrderNum", intNextOrderNum - 1, string.Format("{0} = '{1}'", conFunction4Code.FuncId4Code, strNextKey));
            }
            //7、重新显示DATAGRID
            return true;
        }

    }
}