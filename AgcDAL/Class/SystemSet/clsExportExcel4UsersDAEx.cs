
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsExportExcel4UsersDAEx
表名:ExportExcel4Users
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC_CSV7
工程ID:0005
模块中文名:系统设置
模块英文名:SystemSet
框架-层名:数据处理扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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
    /// 导出Excel用户字段表(ExportExcel4Users)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenDALExCode)
    /// </summary>
    public class clsExportExcel4UsersDAEx : clsExportExcel4UsersDA
    {
        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" mId in ({0})", strKeyList);
            List<clsExportExcel4UsersEN> arrExportExcel4UsersLst = GetObjLst(sbCondition.ToString());
            foreach (clsExportExcel4UsersEN objExportExcel4Users in arrExportExcel4UsersLst)
            {

                objExportExcel4Users.OrderNum = objExportExcel4Users.OrderNum - 10000;

                UpdateBySql2(objExportExcel4Users);
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
            List<clsExportExcel4UsersEN> arrExportExcel4UsersLst = GetObjLst(sbCondition.ToString());
            foreach (clsExportExcel4UsersEN objExportExcel4Users in arrExportExcel4UsersLst)
            {

                objExportExcel4Users.OrderNum = objExportExcel4Users.OrderNum + 10000;

                UpdateBySql2(objExportExcel4Users);
            }
            return true;
        }


        public bool ReOrder(string strIdExportExcel4Users)
        {
            List<clsExportExcel4UsersEN> arrExportExcel4UsersObjList = new clsExportExcel4UsersDA().GetObjLst("IdExportExcel4Users = '" + strIdExportExcel4Users + "' order by OrderNum ");
            int intIndex = 1;
            foreach (clsExportExcel4UsersEN objExportExcel4Users in arrExportExcel4UsersObjList)
            {
                objExportExcel4Users.OrderNum = intIndex;
                //objExportExcel4Users.IdExportExcel4Users
                this.UpdateBySql2(objExportExcel4Users);
                intIndex++;
            }
            return true;
        }


        ///// <summary>
        ///// 设置缺省值
        ///// </summary>
        ///// <param name="lstKey">题目关键字列表</param>
        ///// <param name="strDefaultValue">缺省值</param>
        ///// <returns></returns>
        //public bool SetDefaultValue(ArrayList lstKey, string strDefaultValue)
        //{
        //    string strKeyList;
        //    if (lstKey.Count == 0) return true;
        //    strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
        //    StringBuilder sbCondition = new StringBuilder();
        //    sbCondition.AppendFormat(" mId in ({0})", strKeyList);
        //    List<clsExportExcel4UsersEN> arrExportExcel4UsersLst = GetObjLst(sbCondition.ToString());
        //    foreach (clsExportExcel4UsersEN objExportExcel4Users in arrExportExcel4UsersLst)
        //    {
        //        objExportExcel4Users.DefaultValue = strDefaultValue;
        //        if (objExportExcel4Users.QuestionTypeID == 1)
        //        {
        //            objExportExcel4Users.AnswerTypeID = 3;
        //            objExportExcel4Users.FillInTextWidth = 300;
        //        }
        //        else if (objExportExcel4Users.QuestionTypeID == 2)
        //        {
        //            objExportExcel4Users.AnswerTypeID = 2;
        //        }
        //        else if (objExportExcel4Users.QuestionTypeID == 3)
        //        {
        //            objExportExcel4Users.AnswerTypeID = 1;
        //        }
        //        else if (objExportExcel4Users.QuestionTypeID == 4)
        //        {
        //            objExportExcel4Users.AnswerTypeID = 3;
        //            objExportExcel4Users.FillInTextWidth = 300;
        //        }
        //        else if (objExportExcel4Users.QuestionTypeID == 5)
        //        {
        //            objExportExcel4Users.AnswerTypeID = 3;
        //            objExportExcel4Users.FillInTextWidth = 300;
        //        }
        //        else if (objExportExcel4Users.QuestionTypeID == 6)
        //        {
        //            objExportExcel4Users.AnswerTypeID = 3;
        //            objExportExcel4Users.FillInTextWidth = 300;
        //        }
        //        else if (objExportExcel4Users.QuestionTypeID == 7)
        //        {
        //            objExportExcel4Users.AnswerTypeID = 4;
        //        }
        //        else if (objExportExcel4Users.QuestionTypeID == 8)
        //        {
        //            objExportExcel4Users.AnswerTypeID = 2;
        //        }
        //        if (objExportExcel4Users.IsHaveAdditionalMemo)
        //        {
        //            objExportExcel4Users.MemoTextWidth = 500;
        //        }
        //        if (objExportExcel4Users.IsHaveAdditionalMemo && (objExportExcel4Users.QuestionTypeID == 2 || objExportExcel4Users.QuestionTypeID == 3))
        //        {
        //            objExportExcel4Users.AnswerModeId = "0003";
        //        }
        //        if (objExportExcel4Users.IsHaveAdditionalMemo == false && (objExportExcel4Users.QuestionTypeID == 2 || objExportExcel4Users.QuestionTypeID == 3))
        //        {
        //            objExportExcel4Users.AnswerModeId = "0001";
        //        }
        //        this.UpdateBySql2(objExportExcel4Users);
        //    }
        //    return true;
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="strDirect"></param>
        /// <param name="strmId"></param>
        /// <returns></returns>
        public bool AdjustSequenceNumber(string strDirect, long strmId)
        {
            //操作步骤：
            //1、获取当前所选中的关键字mId。
            //2、根据关键字mId来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字mId
            //5、把当前关键字mId的序号加(减)1
            //6、把下一个序号的关键字mId减(加)1
            //7、重新显示DATAGRID
            ///

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			string strmId;
            long lngPrevmId = 0;	//上一条序号的关键字mId
            long lngNextmId = 0;	//下一条序号的关键字mId
            int intTabRecNum;		//当前表中字段的记录数
            string strCurrIdExportExcel4Users;
            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsExportExcel4UsersEN objExportExcel4Users = new clsExportExcel4UsersEN(strmId);
            //objExportExcel4Users.mId
            this.GetExportExcel4Users(ref objExportExcel4Users);
            intOrderNum = objExportExcel4Users.OrderNum;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            strCurrIdExportExcel4Users = objExportExcel4Users.IdExportExcel4Users;		//获取当前记录的{表ID}
            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("ExportExcel4Users", "IdExportExcel4Users = '" + strCurrIdExportExcel4Users + "'");	//获取当前{表ID}的记录数
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
                strCondition.AppendFormat("IdExportExcel4Users = '{0}' and OrderNum = {1}",
                    strCurrIdExportExcel4Users, intOrderNum - 1);
                lngPrevmId = this.GetFirstID(strCondition.ToString());

                if (lngPrevmId == 0)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat("IdExportExcel4Users = '{0}' and OrderNum = {1}",
                    strCurrIdExportExcel4Users, intOrderNum + 1);
                lngNextmId = this.GetFirstID(strCondition.ToString());

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
                clsGeneralTab2.funSetFldValue("ExportExcel4Users", "OrderNum", intOrderNum - 1, "mId = " + strmId);
                clsGeneralTab2.funSetFldValue("ExportExcel4Users", "OrderNum", intPrevOrderNum + 1, "mId = " + lngPrevmId);
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("ExportExcel4Users", "OrderNum", intOrderNum + 1, "mId = " + strmId);
                clsGeneralTab2.funSetFldValue("ExportExcel4Users", "OrderNum", intNextOrderNum - 1, "mId = " + lngNextmId);
            }
            //7、重新显示DATAGRID
            return true;
        }


    }
}