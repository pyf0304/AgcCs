using AGC.BusinessLogic;
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// clstz_CommKeyWordsBL的扩展类
    /// </summary>
    public class clstz_CommKeyWordsBLEx
    {
        /// <summary>
        /// 维护通用表关键字
        /// </summary>
        /// <param name="strTableName">表名</param>
        /// <param name="strTableKey">表关键值</param>
        /// <param name="strKeyWords">表关键字值</param>
        /// <param name="strUpdUser">修改用户</param>
        /// <returns></returns>
        public static bool EditTableKeyWords(string strTableName, string strTableKey, string strKeyWords, string strUpdUser)
        {
            string strCondition = string.Format("{0}='{1}' And {2}='{3}'",
                contz_CommKeyWords.TableName, strTableName,
                 contz_CommKeyWords.TableKey, strTableKey);
            List<string> arrKeyWordLst_old = clstz_CommKeyWordsBL.GetFldValue(contz_CommKeyWords.Keyword, strCondition);
            string[] strKeyWords_New = strKeyWords.Split(',');
            List<string> arrKeyWordLst_New = new List<string>(strKeyWords_New);
            List<string> arrKeyWords_Del = clsAggregate.TwoAggrDiff(arrKeyWordLst_old, arrKeyWordLst_New);
            List<string> arrKeyWords_Add = clsAggregate.TwoAggrDiff(arrKeyWordLst_New, arrKeyWordLst_old);
            if (arrKeyWords_Del.Count > 0)
            {
                strCondition = string.Format("{0}='{1}' And {2}='{3}' And {4} in ({5})",
                         contz_CommKeyWords.TableName, strTableName,
                         contz_CommKeyWords.TableKey, strTableKey,
                         contz_CommKeyWords.Keyword, clsArray.GetSqlInStrByArray(arrKeyWords_Del, true));
                clstz_CommKeyWordsBL.Deltz_CommKeyWordssByCond(strCondition);
            }
            foreach (string strKeyword in arrKeyWords_Add)
            {
                if (string.IsNullOrEmpty(strKeyword) == true) continue;
                clstz_CommKeyWordsEN objtz_CommKeyWordsEN = new clstz_CommKeyWordsEN();
                objtz_CommKeyWordsEN.TableName = strTableName;
                objtz_CommKeyWordsEN.TableKey = strTableKey;
                objtz_CommKeyWordsEN.Keyword = strKeyword;
                objtz_CommKeyWordsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objtz_CommKeyWordsEN.UpdUser = strUpdUser;
                clstz_CommKeyWordsBL.AddNewRecordBySql2(objtz_CommKeyWordsEN);
            }

            return true;
        }
    }
}
