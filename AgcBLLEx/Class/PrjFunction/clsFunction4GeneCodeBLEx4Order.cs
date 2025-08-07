using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 
    /// </summary>
    public partial class clsFunction4GeneCodeBLEx
    {
        /// <summary>
        /// 把一批记录移到最顶部
        /// </summary>
        /// <param name="arrKeyId">需要移动的记录关键字列表</param>
        /// <param name="strCodeTypeId">层类型Id</param>
        /// <param name="strProgLangTypeId">语言类型Id</param>
        /// <returns></returns>
        public static bool GoTop(List<string> arrKeyId, string strCodeTypeId, string strProgLangTypeId)
        {
            try
            {
                bool bolResult = new clsFunction4GeneCodeDAEx().GoTop(arrKeyId, strCodeTypeId, strProgLangTypeId);
                bolResult = new clsFunction4GeneCodeDAEx().ReOrder(strCodeTypeId, strProgLangTypeId);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错!\r\n" + objException.Message);
            }
        }

        public static bool WordSummarize()
        {
            IEnumerable<string> arrWord = null;
            Dictionary<string, int> dicWordFrequency = new Dictionary<string, int>();
            List<clsFunction4GeneCodeEN> arrObjLst = clsFunction4GeneCodeBL.GetObjLst("1=1");
            foreach (clsFunction4GeneCodeEN objInFor in arrObjLst)
            {
                arrWord = objInFor.ParsedWords.Split(",".ToCharArray());
                foreach (string strWord in arrWord)
                {
                    if (dicWordFrequency.ContainsKey(strWord))
                    {
                        int intCount = dicWordFrequency[strWord];
                        dicWordFrequency[strWord] = intCount + 1;
                    }
                    else
                    {
                        dicWordFrequency.Add(strWord, 1);
                    }
                }
            }
            var arrWordCount = dicWordFrequency.OrderByDescending(x => x.Value).ToList();
            List<string> arrExclude = new List<string>() {
                "WA",
                //"Ctrl",
                "Ajax",
                "WApi",
                //"btn",
                //"Click",
                //"V",
                //"SP",
                //"By",
                //"Ex",
                "BLEx",
                //"Static",
                //"Record",
                //"Node",
                "Mvc",
                "Region",
                "App",
                "WAEx",
                //"View",
                "4",
                "Async",
                "JS",
                "Js",
                "_",
                "#",
                ":",
                "BL",
                "DA",
                "JDA",
                "Neo",
                "Neo4J",
                "Gen",
                "CS",
                "Java",
                //"S",
                "Ts",
                //"Web",
                "Ws",
                "WS",
                "Swift",
                "Swift3" };
            List<string> arrWord_Finished = arrWordCount.Select(x => x.Key).Where(x => arrExclude.Contains(x) == false).ToList();
            string strTemplate = clsString.combineStrS("0", arrWord_Finished.Count);
            foreach (clsFunction4GeneCodeEN objInFor in arrObjLst)
            {
                List<string> arrWord_New = new List<string>();
                StringBuilder sbWordVector = new StringBuilder(strTemplate);
                arrWord = objInFor.ParsedWords.Split(",".ToCharArray());
                foreach (string strWord in arrWord)
                {
                    var index = arrWord_Finished.IndexOf(strWord);
                    if (index >= 0)
                    {
                        sbWordVector.Replace("0", "1", index, 1);
                        arrWord_New.Add(strWord);
                    }
                }
                string sstrWord = string.Join(",", arrWord_New);
                objInFor
                    .SetWordVector(sbWordVector.ToString())
                    .SetParsedWordsExcluded(sstrWord)
                    .Update();
            }
                
                               
            return true;
        }

        /// <summary>
        /// 把函数名分解成词
        /// </summary>
        /// <returns></returns>
        public static bool FuncName_ParseWord()
        {
            List<clsFunction4GeneCodeEN> arrObjLst = clsFunction4GeneCodeBL.GetObjLst("1=1");
            foreach (clsFunction4GeneCodeEN objInFor in arrObjLst)
            {
                List<string> arrWord = clsParseWord.ParseFuncNameIntoWord(objInFor.FuncName);
                string sstrWord = string.Join(",", arrWord);
                objInFor.ParsedWords = sstrWord;
                objInFor.Update();
            }
            return true;
        }

        /// <summary>
        /// 把一批记录移到最底部
        /// </summary>
        /// <param name="arrKeyId">需要移动的记录关键字列表</param>
        /// <param name="strCodeTypeId">层类型Id</param>
        /// <param name="strProgLangTypeId">语言类型Id</param>
        /// <returns></returns>
        public static bool GoBottom(List<string> arrKeyId, string strCodeTypeId, string strProgLangTypeId)
        {
            try
            {
                bool bolResult = new clsFunction4GeneCodeDAEx().GoBottom(arrKeyId, strCodeTypeId, strProgLangTypeId);
                bolResult = new clsFunction4GeneCodeDAEx().ReOrder(strCodeTypeId, strProgLangTypeId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错!\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 调整次序。
        /// </summary>
        /// <param name="strDirect">方向：向上、向下</param>
        /// <param name="strCurrKey">需要调整记录的关键字</param>
        /// <returns></returns>
        public static bool AdjustSequenceNumber(string strDirect, string strCurrKey)
        {
            try
            {
                bool bolResult = new clsFunction4GeneCodeDAEx().AdjustSequenceNumber(strDirect, strCurrKey);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错!\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 重序。针对模板Id的所有函数重序
        /// </summary>
        /// <param name="strCodeTypeId">层类型Id</param>
        /// <param name="strProgLangTypeId">语言类型Id</param>
        /// <returns></returns>
        public static bool ReOrder(string strCodeTypeId, string strProgLangTypeId)
        {
            try
            {
                bool bolResult = new clsFunction4GeneCodeDAEx().ReOrder(strCodeTypeId, strProgLangTypeId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错!\r\n" + objException.Message);
            }

        }

        public static int ParseFeatureId()
        {
            clsFunction4GeneCodeBL.SetFldValue(clsFunction4GeneCodeEN._CurrTabName,
                conFunction4GeneCode.FeatureId, "",
                string.Format("{0} like '分析功能%'", conFunction4GeneCode.Memo));
            List<clsFunction4GeneCodeEN> arrObjLst = clsFunction4GeneCodeBL.GetObjLst("1=1");
            List<clsFunction4GeneCodeEN> arrObjLst_Template = arrObjLst.Where(x=>x.IsTemplate == true).ToList();
            int intCount = 0;
            foreach (clsFunction4GeneCodeEN objInFor in arrObjLst)
            {
                if (objInFor.IsTemplate == true) continue;
                if (string.IsNullOrEmpty(objInFor.FeatureId) == false)
                {
                    clsPrjFeatureEN objPrjFeature = clsPrjFeatureBL.GetObjByFeatureIdCache(objInFor.FeatureId);
                    if (objPrjFeature.FeatureTypeId == enumPrjFeatureType.GeneralFeature_05) continue;
                }
                Dictionary<string, int> dicJL = new Dictionary<string, int>();
                foreach (clsFunction4GeneCodeEN objInFor2 in arrObjLst_Template)
                {              
                    int intDistance = clsParseWord.CalcDistance(objInFor2.WordVector, objInFor.WordVector);
                    dicJL.Add(objInFor2.FuncId4GC, intDistance);
                }
                var arrDistance = dicJL.OrderBy(x => x.Value);
                if (arrDistance.Count() == 0) continue;
                string strFuncId4GC = arrDistance.First().Key;
                clsFunction4GeneCodeEN objFunction4GeneCode = arrObjLst.Find(x => x.FuncId4GC == strFuncId4GC);
                objInFor.SetFeatureId(objFunction4GeneCode.FeatureId)
                    .SetMemo("分析功能, 并复制于:" + strFuncId4GC)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1));
                objInFor.Update();
                intCount++;
            }
            return intCount;
        }
    }
}
