using AGC.BusinessLogic;
using AGC.Entity;

using com.taishsoft.commdb;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsLog4GeneViewCodeBLEx
    {
        public static clsLog4GeneViewCodeEN GetObjByViewId(List<clsLog4GeneViewCodeEN> arrObjLst, string strViewId)
        {
            IEnumerable<clsLog4GeneViewCodeEN> arrLog4GeneViewCodeObjLst_Sel1 =
            from objLog4GeneViewCodeEN in arrObjLst
            where objLog4GeneViewCodeEN.ViewId == strViewId
            select objLog4GeneViewCodeEN;
            List<clsLog4GeneViewCodeEN> arrLog4GeneViewCodeObjLst_Sel = new List<clsLog4GeneViewCodeEN>();
            foreach (clsLog4GeneViewCodeEN obj in arrLog4GeneViewCodeObjLst_Sel1)
            {
                arrLog4GeneViewCodeObjLst_Sel.Add(obj);
            }
            if (arrLog4GeneViewCodeObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrLog4GeneViewCodeObjLst_Sel[0];
        }


        public static bool AddLog4GeneViewCode(string strViewId, string strUserId, string strVersion)
        {
            clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = new clsLog4GeneViewCodeEN();
            objLog4GeneViewCodeEN.GeneCodeDate = clsDateTime.getTodayDateTimeStr(1);
            objLog4GeneViewCodeEN.VersionGeneCode = strVersion;
            objLog4GeneViewCodeEN.UserId = strUserId;
            objLog4GeneViewCodeEN.ViewId = strViewId;
            objLog4GeneViewCodeEN.PrjId = strViewId.Substring(0,4);

            string strCondition = objLog4GeneViewCodeEN.GetUniCondStr();
            if (clsLog4GeneViewCodeBL.IsExistRecord(strCondition) == false)
            {
                clsLog4GeneViewCodeBL.AddNewRecordBySql2(objLog4GeneViewCodeEN);
            }
            else
            {
                objLog4GeneViewCodeEN.UpdateWithCondition(strCondition);
            }
            return true;
        }

        public static bool AddLog4GeneViewCode(string strViewId, string strFuncId4GC, string strUserId, string strVersion)
        {
            clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = new clsLog4GeneViewCodeEN();
            objLog4GeneViewCodeEN.GeneCodeDate = clsDateTime_Db.GetDataBaseDateTime14();
            objLog4GeneViewCodeEN.VersionGeneCode = strVersion;
            objLog4GeneViewCodeEN.UserId = strUserId;
            objLog4GeneViewCodeEN.ViewId = strViewId;
            string strCondition = objLog4GeneViewCodeEN.GetUniCondStr();
            if (clsLog4GeneViewCodeBL.IsExistRecord(strCondition) == false)
            {
                clsLog4GeneViewCodeBL.AddNewRecordBySql2(objLog4GeneViewCodeEN);
            }
            else
            {
                objLog4GeneViewCodeEN.UpdateWithCondition(strCondition);
            }
            return true;
        }
        public static bool AddLog4GeneViewCodeByMachine(string strViewId, string strUserId, string strVersion, string strCodeTypeId, string strMachineName)
        {
            clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = new clsLog4GeneViewCodeEN();
            objLog4GeneViewCodeEN.GeneCodeDate = clsDateTime.getTodayDateTimeStr(1);
            objLog4GeneViewCodeEN.VersionGeneCode = strVersion;
            objLog4GeneViewCodeEN.UserId = strUserId;
            objLog4GeneViewCodeEN.ViewId = strViewId;
            objLog4GeneViewCodeEN.PrjId = strViewId.Substring(0, 4);
            objLog4GeneViewCodeEN.CodeTypeId = strCodeTypeId;
            objLog4GeneViewCodeEN.MachineName = strMachineName;

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}'", conLog4GeneViewCode.ViewId, strViewId);
            sbCondition.AppendFormat(" and {0} = '{1}'", conLog4GeneViewCode.UserId, strUserId);

            if (string.IsNullOrEmpty(strCodeTypeId) == true)
            {
                sbCondition.AppendFormat(" and {0} is null", conLog4GeneViewCode.CodeTypeId);
            }
            else
            {
                sbCondition.AppendFormat(" and {0} = '{1}'", conLog4GeneViewCode.CodeTypeId, strCodeTypeId);
            }

            if (string.IsNullOrEmpty(strMachineName) == true)
            {
                sbCondition.AppendFormat(" and {0} is null", conLog4GeneViewCode.MachineName);
            }
            else
            {
                sbCondition.AppendFormat(" and {0} = '{1}'", conLog4GeneViewCode.MachineName, strMachineName);
            }

            string strCondition = sbCondition.ToString();
            if (clsLog4GeneViewCodeBL.IsExistRecord(strCondition) == false)
            {
                clsLog4GeneViewCodeBL.AddNewRecordBySql2(objLog4GeneViewCodeEN, false);
            }
            else
            {
                objLog4GeneViewCodeEN.UpdateWithCondition(strCondition);
            }

            // 同用户 + 同机器 + 同界面 + 同代码类型 最多保留5条，超出则删除最老记录
            StringBuilder sbKeepCond = new StringBuilder();
            sbKeepCond.AppendFormat("{0} = '{1}'", conLog4GeneViewCode.UserId, strUserId);
            sbKeepCond.AppendFormat(" and {0} = '{1}'", conLog4GeneViewCode.ViewId, strViewId);

            if (string.IsNullOrEmpty(strCodeTypeId) == true)
            {
                sbKeepCond.AppendFormat(" and {0} is null", conLog4GeneViewCode.CodeTypeId);
            }
            else
            {
                sbKeepCond.AppendFormat(" and {0} = '{1}'", conLog4GeneViewCode.CodeTypeId, strCodeTypeId);
            }

            if (string.IsNullOrEmpty(strMachineName) == true)
            {
                sbKeepCond.AppendFormat(" and {0} is null", conLog4GeneViewCode.MachineName);
            }
            else
            {
                sbKeepCond.AppendFormat(" and {0} = '{1}'", conLog4GeneViewCode.MachineName, strMachineName);
            }

            List<clsLog4GeneViewCodeEN> arrLogLst = clsLog4GeneViewCodeBL.GetObjLst(sbKeepCond.ToString() + " order by mId asc");
            if (arrLogLst.Count > 5)
            {
                int intDelCount = arrLogLst.Count - 5;
                for (int i = 0; i < intDelCount; i++)
                {
                    clsLog4GeneViewCodeBL.DelRecord(arrLogLst[i].mId);
                }
            }
            clsViewInfoBLEx.SetGeneCodeDate(strViewId, objLog4GeneViewCodeEN.GeneCodeDate);
            return true;
        }
    }
}
