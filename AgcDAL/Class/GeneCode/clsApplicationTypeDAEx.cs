
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsApplicationTypeDAEx
表名:ApplicationType
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC
工程ID:0005
模块中文名:工程管理
模块英文名:PrjManage
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
    /// 应用程序类型(ApplicationType)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenDALExCode)
    /// </summary>
    public class clsApplicationTypeDAEx : clsApplicationTypeDA
    {
        //以下是属性变量

        public bool GoTop(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" ApplicationTypeId in ({0})", strKeyList);
            List<clsApplicationTypeEN> arrApplicationTypeLst = GetObjLst(sbCondition.ToString());
            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeLst)
            {

                objApplicationType.OrderNum = objApplicationType.OrderNum - 10000;

                UpdateBySql2(objApplicationType);
            }
            return true;
        }
        public bool GoBottom(List<string> lstKey)
        {
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = clsArray.GetSqlInStrByArray(lstKey, false);
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" ApplicationTypeId in ({0})", strKeyList);
            List<clsApplicationTypeEN> arrApplicationTypeLst = GetObjLst(sbCondition.ToString());
            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeLst)
            {

                objApplicationType.OrderNum = objApplicationType.OrderNum + 10000;

                UpdateBySql2(objApplicationType);
            }
            return true;
        }
        public bool ReOrder()
        {
            List<clsApplicationTypeEN> arrApplicationTypeObjList = new clsApplicationTypeDA().GetObjLst(" 1=1 order by OrderNum ");
            int intIndex = 1;
            foreach (clsApplicationTypeEN objApplicationType in arrApplicationTypeObjList)
            {
                objApplicationType.OrderNum = intIndex;
                this.UpdateBySql2(objApplicationType);
                intIndex++;
            }
            return true;
        }
        public bool AdjustSequenceNumber(string strDirect, int intApplicationTypeId)
        {
            //操作步骤：
            //1、获取当前所选中的关键字ApplicationTypeId。
            //2、根据关键字ApplicationTypeId来获取字的序号
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，
            //  3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
            //      即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
            //      如果是向上移动，就判断当前序号是否“大于”1，
            //      即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
            //4、获取下(上)一个序号字段的关键字ApplicationTypeId
            //5、把当前关键字ApplicationTypeId的序号加(减)1
            //6、把下一个序号的关键字ApplicationTypeId减(加)1
            //7、重新显示DATAGRID
            ///

            int intOrderNum;	//当前记录的序号
            int intPrevOrderNum, intNextOrderNum;	//上下两条记录的序号
            //			int intApplicationTypeId;
            int intPrevApplicationTypeId = 0;	//上一条序号的关键字ApplicationTypeId
            int intNextApplicationTypeId = 0;	//下一条序号的关键字ApplicationTypeId
            int intTabRecNum;       //当前表中字段的记录数

            //ArrayList arrID;
            StringBuilder strCondition = new StringBuilder();
            //1、获取当前所选中的字段ID。

            clsApplicationTypeEN objApplicationType = GetObjByApplicationTypeId(intApplicationTypeId);

            intOrderNum = objApplicationType.OrderNum;
            intPrevOrderNum = intOrderNum - 1;
            intNextOrderNum = intOrderNum + 1;
            //3、如果当前序号是否是末端序号，
            //  3.1 如果是末端序号，就退出，

            intTabRecNum = clsGeneralTab2.funGetRecCountByCond("ApplicationType", " 1=1 ");	//获取当前{表ID}的记录数
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

            //4、获取下(上)一个序号字段的关键字ApplicationTypeId
            if (strDirect == "UP")
            {
                strCondition.AppendFormat(" 1=1 and OrderNum = {0}", intOrderNum - 1);
                intPrevApplicationTypeId = this.GetFirstID(strCondition.ToString());

                if (intPrevApplicationTypeId == 0)
                {
                    throw new Exception("获取上一条记录的关键字出错!");
                }
            }
            else if (strDirect == "DOWN")
            {
                strCondition.AppendFormat(" 1=1 and OrderNum = {0}", intOrderNum + 1);
                intNextApplicationTypeId = this.GetFirstID(strCondition.ToString());
                if (intNextApplicationTypeId == 0)
                {
                    throw new Exception("获取下一条记录的关键字出错!");
                }
            }
            else
            {
                throw new Exception("方向参数出错!");
            }
            //5、把当前关键字ApplicationTypeId的序号加(减)1
            //6、把下一个序号的关键字ApplicationTypeId减(加)1
            if (strDirect == "UP")
            {
                clsGeneralTab2.funSetFldValue("ApplicationType", "OrderNum", intOrderNum - 1, "ApplicationTypeId = " + intApplicationTypeId);
                clsGeneralTab2.funSetFldValue("ApplicationType", "OrderNum", intPrevOrderNum + 1, "ApplicationTypeId = " + intPrevApplicationTypeId);
            }
            else if (strDirect == "DOWN")
            {
                clsGeneralTab2.funSetFldValue("ApplicationType", "OrderNum", intOrderNum + 1, "ApplicationTypeId = " + intApplicationTypeId);
                clsGeneralTab2.funSetFldValue("ApplicationType", "OrderNum", intNextOrderNum - 1, "ApplicationTypeId = " + intNextApplicationTypeId);
            }
            //7、重新显示DATAGRID
            return true;
        }

    }
}