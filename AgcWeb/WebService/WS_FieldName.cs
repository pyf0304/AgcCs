using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Collections;


using AGC.Entity;

using com.taishsoft.commdb;

using AGC.BusinessLogicEx;

using AGC;
using AGC.FunClass;
using AGC.BusinessLogic;

namespace AGC.WebSrv
{
    /// <summary>
    ///WS_FieldName 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。 
    [System.Web.Script.Services.ScriptService]
    public class WS_FieldName : System.Web.Services.WebService
    {

        public WS_FieldName()
        {

            //如果使用设计的组件，请取消注释以下行 
            //InitializeComponent(); 
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public bool RefreshWorkList()
        {
            autoCompleteWordList = null;
            return true;
        }
        /// ＜summary＞
        /// 获取数据的方法GetCompleteList
        /// ＜summary＞
        //定义静态数组用于保存获取的数据
        public static string[] autoCompleteWordList = null;
        public static string strPrjId = "0005";
        [WebMethod]
        public String[] GetCompleteList(string prefixText, int count)
        {
            if (autoCompleteWordList == null)
            {
                //string[] temp = File.ReadAllLines(Server.MapPath("~/App_Data/TextFile.txt"));
                List<string> arr = new List<string>();
                try
                {
                    arr = clsGeneralTab2.funGetFldValue("FieldTab", "FldName", string.Format("PrjId='{0}'", strPrjId));
                }
                catch (Exception objException)
                {
                    string strMsg = objException.Message;
                    ErrorInformationBL.AddInformation("WS_FieldName", "GetCompleteList", strMsg, clsCommonSession.UserId);
                }
                string[] temp = new string[arr.Count];
                int iIndex = 0;
                foreach (string str in arr)
                {
                    temp[iIndex] = str;
                    iIndex++;
                }
                Array.Sort(temp, new CaseInsensitiveComparer());
                autoCompleteWordList = temp;
            }

            int index = Array.BinarySearch(autoCompleteWordList, prefixText, new CaseInsensitiveComparer());
            if (index < 0)
            {
                index = ~index;
            }

            int matchingCount;
            for (matchingCount = 0; matchingCount < count && index + matchingCount < autoCompleteWordList.Length; matchingCount++)
            {
                if (!autoCompleteWordList[index + matchingCount].StartsWith(prefixText, StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
            }
            String[] returnValue = new string[matchingCount];
            if (matchingCount > 0)
            {
                Array.Copy(autoCompleteWordList, index, returnValue, 0, matchingCount);
            }
            return returnValue;
        }

        [WebMethod]
        public bool InitCompleteWordList(string pstrPrjId)
        {
            autoCompleteWordList = null;
            strPrjId = pstrPrjId;
            return true;
        }
    }

}